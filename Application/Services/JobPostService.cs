using Application.Interface;
using Application.Request.JobPost;
using Application.Response;
using Application.Response.JobPost;
using Application.Response.User;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Hangfire;
using Application.MyBackgroundJob;
using Application.Response.JobPostActivityComment;
using Application.Extensions;
using Newtonsoft.Json;
using Application.Response.AnalyzedResult;

namespace Application.Services
{
    public class JobPostService : IJobPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public JobPostService(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _emailService = emailService;
        }


        public async Task<ApiResponse> AddNewJobPostAsync(JobPostRequest jobPostRequest)
        {
            try
            {
                var jobPost = _mapper.Map<JobPost>(jobPostRequest);
                var company = await _unitOfWork.Companys.GetAsync(c => c.Id == jobPostRequest.CompanyId);
                if (company == null)
                {
                    return new ApiResponse().SetBadRequest("Company not found");
                }
                var jobType = await _unitOfWork.JobTypes.GetAsync(jt => jt.Id == jobPostRequest.JobTypeId);
                if (jobType == null)
                {
                    return new ApiResponse().SetBadRequest("Job type not found");
                }

                var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == jobPostRequest.UserId);
                if (user == null)
                {
                    return new ApiResponse().SetBadRequest("User not found");
                }
                var skillSets = await _unitOfWork.SkillSets.GetAllAsync(u => jobPostRequest.SkillSetIds.Contains(u.Id));
                if (jobPostRequest.SkillSetIds.Count != skillSets.Count)
                {
                    return new ApiResponse().SetBadRequest("Job Skill Set Id is invalid!");
                }

                var listJobPostSkillSet = new List<JobSkillSet>();
                foreach (var skillSet in skillSets)
                {
                    listJobPostSkillSet.Add(new JobSkillSet
                    {
                        SkillSetId = skillSet.Id,
                        JobPost = jobPost
                    });
                }
                jobPost.JobSkillSets = listJobPostSkillSet;
                jobPost.Company = company;
                jobPost.JobType = jobType;
                jobPost.UserAccount = user;
                jobPost.CreatedDate = DateTime.UtcNow;
                jobPost.PostingDate = DateTime.UtcNow;
                jobPost.JobPostReviewStatus = JobPostReviewStatus.Pending;

                // Generate a vector for the job post
                jobPost.Vector = GenerateVector(jobPost);

                await _unitOfWork.JobPosts.AddAsync(jobPost);
                await _unitOfWork.SaveChangeAsync();


                // Call Hangfire to send emails after job post creation
                BackgroundJob.Enqueue<EmailJob>(emailJob => emailJob.SendEmailsToFollowers(jobPostRequest.CompanyId, jobPost.JobTitle));

                return new ApiResponse().SetOk(jobPost.Id);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }


        public async Task<ApiResponse> GetJobPostAsync()
        {
            try
            {
                //var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(x => x.JobPostReviewStatus == JobPostReviewStatus.Accepted, x => x.Include(x => x.Company)
                //                                                                  .Include(x => x.JobLocations)
                //                                                                        .ThenInclude(x => x.Location)
                //                                                                  .Include(x => x.JobType)
                //                                                                  .Include(x => x.JobSkillSets)
                //                                                                        .ThenInclude(x => x.SkillSet));
                var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(null, x => x.Include(x => x.Company)
                                                                                  .Include(x => x.JobLocations)
                                                                                        .ThenInclude(x => x.Location)
                                                                                  .Include(x => x.JobType)
                                                                                  .Include(x => x.JobSkillSets)
                                                                                        .ThenInclude(x => x.SkillSet));

                var jobPostsResponse = _mapper.Map<List<JobPostResponse>>(jobPosts);

                return new ApiResponse().SetOk(jobPostsResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }

        }


        public async Task<ApiResponse> AddSkillSetToJobPost(JobPostSkillSetRequest jobPostSkillSetRequest)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var jobPostSkillSet = await _unitOfWork.JobSkillSets.GetAsync(x => x.SkillSetId == jobPostSkillSetRequest.SkillSetId &&
                                                                                   x.JobPostId == jobPostSkillSetRequest.JobPostId);
                if (jobPostSkillSet != null)
                {
                    return response.SetBadRequest($"Skill Set already exist in this Job Post !!");
                }

                var skillSet = await _unitOfWork.SkillSets.GetAsync(x => x.Id == jobPostSkillSetRequest.SkillSetId);
                if (skillSet == null)
                {
                    return response.SetBadRequest($"Skill set id {jobPostSkillSetRequest.SkillSetId} is not found !!");
                }

                var jobpost = await _unitOfWork.SkillSets.GetAsync(x => x.Id == jobPostSkillSetRequest.JobPostId);
                if (skillSet == null)
                {
                    return response.SetBadRequest($"Job post id {jobPostSkillSetRequest.JobPostId} is not found !!");
                }

                await _unitOfWork.JobSkillSets.AddAsync(new JobSkillSet
                {
                    //SkillLevelRequired = jobPostSkillSetRequest.SkillLevelRequired,
                    SkillSetId = jobPostSkillSetRequest.SkillSetId,
                    JobPostId = jobPostSkillSetRequest.JobPostId
                });
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("Add Skill Set To Job Post Success !!");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetJobSeekerByJobPost(int jobPostId)
        {
            // Fetch JobPostActivities including the related UserAccount
            var jobPostAct = await _unitOfWork.JobPostActivities.GetAllAsync(
                x => x.JobPostId == jobPostId,
                x => x.Include(x => x.UserAccount)
                      .Include(x => x.CV)
                      .Include(x => x.JobPostActivityComments!)
            );

            // Map JobPostActivity to CandidateResponse
            var candidateResponses = jobPostAct.Select(x => new CandidateResponse
            {
                Id = x.UserAccount.Id,
                //UserName = x.UserAccount.UserName,
                FirstName = x.UserAccount.FirstName,
                LastName = x.UserAccount.LastName,
                Email = x.UserAccount.Email,
                PhoneNumber = x.UserAccount.PhoneNumber,
                CVId = x.CvId,
                CVPath = x.CV?.Url ?? string.Empty, // Assuming CV has a property 'Path'
                JobPostActivityId = x.Id,
                Status = x.Status.ToString(),
                JobPostActivityComments = x.JobPostActivityComments!.Select(x => new JobPostActivityCommentResponse
                {
                    Id = x.Id,
                    CommentDate = x.CommentDate,
                    CommentText = x.CommentText,
                    Rating = x.Rating,
                }).ToList(),
                AnalyzedResult = new AnalyzedResultResponse
                {
                    Success = true,
                    ProcessingTime = 0.15,
                    DeviceUsed = "cpu",
                    MatchDetails = new MatchDetails
                    {
                        JobId = 4,
                        JobTitle = "test",
                        CandidateName = "Example Name",
                        CandidateEmail = "example@gmail.com",
                        Scores = new Scores
                        {
                            OverallMatch = 52.52,
                            SkillMatch = 100.0,
                            ExperienceMatch = 0.0,
                            ContentSimilarity = 41.73
                        },
                        SkillAnalysis = new SkillAnalysis
                        {
                            MatchingSkills = new List<string> { "javascript", "python" },
                            MissingSkills = new List<string>(),
                            AdditionalSkills = new List<string> { "communication", "git", "problem solving", "react", "vs code" }
                        },
                        ExperienceAnalysis = new ExperienceAnalysis
                        {
                            RequiredYears = 2.0,
                            CandidateYears = 0.0,
                            MeetsRequirement = false
                        },
                        Recommendation = new Recommendation
                        {
                            Category = "Moderate Match",
                            Action = "Consider for Interview"
                        }
                    }
                }
            }).ToList();

            // Return the mapped CandidateResponse list
            return new ApiResponse().SetOk(candidateResponses);
        }



        public async Task<ApiResponse> GetJobPostById(int jobPostId)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var jobPost = await _unitOfWork.JobPosts.GetAsync(x => x.Id == jobPostId, x => x.Include(x => x.Company)
                                                                                                .Include(x => x.JobLocations)
                                                                                                    .ThenInclude(x => x.Location)
                                                                                                .Include(x => x.JobType)
                                                                                                .Include(x => x.JobSkillSets)
                                                                                                    .ThenInclude(x => x.SkillSet));
                if (jobPost == null)
                {
                    return response.SetBadRequest("Can not found jobPost Id" + jobPostId);
                }
                var jobPostResponse = _mapper.Map<JobPostResponse>(jobPost);
                return response.SetOk(jobPostResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> SearchJobs(SearchJobPostRequest searchJobPostRequest)
        {
            var jobPosts = await _unitOfWork.JobPosts.SearchJobPosts(searchJobPostRequest);
            var result = _mapper.Map<List<JobPostResponse>>(jobPosts ?? []);
            return new ApiResponse().SetOk(result.ToPaginationResponse(searchJobPostRequest.PageIndex, searchJobPostRequest.PageSize));
        }

        public async Task<ApiResponse> UpdateStatusJobPost(int id, JobPostReviewStatus status)
        {
            var post = await _unitOfWork.JobPosts.GetAsync(post => post.Id == id);

            if (post == null)
            {
                return new ApiResponse().SetNotFound();
            }

            post.JobPostReviewStatus = status;
            await _unitOfWork.SaveChangeAsync();
            return new ApiResponse().SetOk(post);
        }

        public async Task<ApiResponse> UpdateJobPost(int id, JobPostRequest request)
        {
            var jobPost = await _unitOfWork.JobPosts.GetAsync(post => post.Id == id, x => x.Include(p => p.JobSkillSets));

            if (jobPost == null)
            {
                return new ApiResponse().SetNotFound();
            }

            jobPost.JobTitle = request.JobTitle;
            jobPost.JobDescription = request.JobDescription;
            jobPost.Salary = request.Salary;
            jobPost.ExperienceRequired = request.ExperienceRequired;
            jobPost.QualificationRequired = request.QualificationRequired;
            jobPost.Benefits = request.Benefits;
            //jobPost.SkillLevelRequired = request.SkillLevelRequired;
            jobPost.JobTypeId = request.JobTypeId;
            jobPost.ImageURL = request.ImageURL;

            //replace all skill set
            var validSkillIds = new List<int>();

            foreach (var newId in request.SkillSetIds)
            {
                var skillSet = await _unitOfWork.SkillSets.GetAsync(s => s.Id == newId);
                if (skillSet != null)
                {
                    validSkillIds.Add(skillSet.Id);
                }
            }

            if (validSkillIds.Count >= 0)
            {
                jobPost.JobSkillSets?.Clear();

                jobPost.JobSkillSets?.AddRange(validSkillIds.Select(skillId => new JobSkillSet
                {
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    JobPostId = id,
                    SkillSetId = skillId,
                }).ToList());
            }

            //re-submit rejected post
            if (jobPost.JobPostReviewStatus == JobPostReviewStatus.Rejected)
            {
                jobPost.JobPostReviewStatus = JobPostReviewStatus.Pending;
            }

            await _unitOfWork.SaveChangeAsync();
            return new ApiResponse().SetOk();
        }
        public async Task<ApiResponse> GetAllJobPostPending()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var jobPosts = await _unitOfWork.JobPosts.GetAllAsync(x => x.JobPostReviewStatus == JobPostReviewStatus.Pending, x => x.Include(x => x.Company)
                                                                                  .Include(x => x.JobLocations)
                                                                                        .ThenInclude(x => x.Location)
                                                                                  .Include(x => x.JobType)
                                                                                  .Include(x => x.JobSkillSets)
                                                                                        .ThenInclude(x => x.SkillSet));
                var jobPostsResponse = _mapper.Map<List<JobPostResponse>>(jobPosts);
                return new ApiResponse().SetOk(jobPostsResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> SeedsData()
        {
            //string currentDirectory = Directory.GetCurrentDirectory();
            //string parentDirectory = Directory.GetParent(currentDirectory).FullName;

            //string jsonPath = Path.Combine(parentDirectory, "jobPostData.json");
            //string jsonContent = File.ReadAllText(jsonPath);
            //List<JobPost> jobs = JsonConvert.DeserializeObject<List<JobPost>>(jsonContent);
            //await _unitOfWork.JobPosts.AddRangeAsync(jobs);
            await _unitOfWork.SkillSets.AddRangeAsync(skillSetsData);
            await _unitOfWork.Companys.AddRangeAsync(companiesSeedData);
            await _unitOfWork.BusinessStreams.AddRangeAsync(businessStreamsSeedData);
            var companies = await _unitOfWork.Companys.GetAllAsync(x => true);
            foreach (var company in companies.Where(c => c.BusinessStreamId == null).ToList())
            {
                var r = new Random();
                company.BusinessStreamId = r.Next(1, businessStreamsSeedData.Count);
            }
            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetOk();
        }

        private float[] GenerateVector(JobPost jobPost)
        {
            // Combine job post details into a single string
            string combinedText = $"{jobPost.JobTitle} {jobPost.JobDescription} {jobPost.Benefits} Experience: {jobPost.ExperienceRequired} years";

            // Add skill set names to the combined text
            //if (jobPost.JobSkillSets != null && jobPost.JobSkillSets.Any())
            //{
            //    string skillSetNames = string.Join(" ", jobPost.JobSkillSets.Select(js => js.SkillSet.Name));
            //    combinedText += $" {skillSetNames}";
            //}

            // Placeholder logic to convert the combined text into a vector
            // Replace this with an actual model or service call for generating embeddings
            return combinedText.Split(' ').Select(word => (float)word.Length).ToArray();
        }

        private static List<SkillSet> skillSetsData =
        [
        new SkillSet { Name = "C# Programming", Shorthand = "C#", Description = "Proficiency in C# programming language and .NET framework." },
        new SkillSet { Name = "Java Programming", Shorthand = "Java", Description = "Strong understanding of Java and related technologies." },
        new SkillSet { Name = "Python Programming", Shorthand = "Python", Description = "Experience with Python and its libraries like NumPy, Pandas." },
        new SkillSet { Name = "JavaScript", Shorthand = "JS", Description = "Knowledge of JavaScript and front-end frameworks like React, Angular, or Vue.js." },
        new SkillSet { Name = "HTML/CSS", Shorthand = "HTML/CSS", Description = "Proficient in HTML and CSS for web development." },
        new SkillSet { Name = "SQL", Shorthand = "SQL", Description = "Experience with SQL databases like MySQL, PostgreSQL, or SQL Server." },
        new SkillSet { Name = "NoSQL", Shorthand = "NoSQL", Description = "Familiarity with NoSQL databases such as MongoDB or Cassandra." },
        new SkillSet { Name = "Cloud Computing", Shorthand = "Cloud", Description = "Knowledge of cloud platforms like AWS, Azure, or GCP." },
        new SkillSet { Name = "DevOps", Shorthand = "DevOps", Description = "Understanding of DevOps practices and tools." },
        new SkillSet { Name = "Agile Development", Shorthand = "Agile", Description = "Experience working in an Agile development environment." },
        new SkillSet { Name = "Git", Shorthand = "Git", Description = "Proficiency in using Git for version control." },
        new SkillSet { Name = "Docker", Shorthand = "Docker", Description = "Experience with containerization using Docker." },
        new SkillSet { Name = "Kubernetes", Shorthand = "K8s", Description = "Knowledge of Kubernetes for container orchestration." },
        new SkillSet { Name = "Microservices", Shorthand = "Microservices", Description = "Understanding of microservices architecture and development." },
        new SkillSet { Name = "RESTful APIs", Shorthand = "REST APIs", Description = "Experience with designing and developing RESTful APIs." },
        new SkillSet { Name = "Testing", Shorthand = "Testing", Description = "Knowledge of software testing methodologies and frameworks." },
        new SkillSet { Name = "Problem Solving", Shorthand = "Problem Solving", Description = "Strong problem-solving and analytical skills." },
        new SkillSet { Name = "Communication", Shorthand = "Communication", Description = "Excellent written and verbal communication skills." },
        new SkillSet { Name = "Teamwork", Shorthand = "Teamwork", Description = "Ability to work effectively in a team environment." },
        new SkillSet { Name = "Time Management", Shorthand = "Time Management", Description = "Strong time management and organizational skills." },
        new SkillSet { Name = "Go Programming", Shorthand = "Go", Description = "Experience with Go programming language." },
        new SkillSet { Name = "Ruby on Rails", Shorthand = "Ruby", Description = "Knowledge of Ruby on Rails framework." },
        new SkillSet { Name = "PHP", Shorthand = "PHP", Description = "Familiarity with PHP programming language." },
        new SkillSet { Name = "Swift", Shorthand = "Swift", Description = "Experience with Swift for iOS development." },
        new SkillSet { Name = "Kotlin", Shorthand = "Kotlin", Description = "Knowledge of Kotlin for Android development." },
        new SkillSet { Name = "Flutter", Shorthand = "Flutter", Description = "Experience with Flutter framework for cross-platform development." },
        new SkillSet { Name = "React Native", Shorthand = "React Native", Description = "Familiarity with React Native for mobile app development." },
        new SkillSet { Name = "Machine Learning", Shorthand = "ML", Description = "Understanding of machine learning algorithms and techniques." },
        new SkillSet { Name = "Data Science", Shorthand = "Data Science", Description = "Knowledge of data science principles and tools." },
        new SkillSet { Name = "Cybersecurity", Shorthand = "Cybersecurity", Description = "Understanding of cybersecurity concepts and best practices." },
        new SkillSet { Name = "UI/UX Design", Shorthand = "UI/UX", Description = "Experience with user interface and user experience design." },
        new SkillSet { Name = "Database Administration", Shorthand = "DBA", Description = "Knowledge of database administration and management." },
        new SkillSet { Name = "Software Architecture", Shorthand = "Architecture", Description = "Understanding of software architecture patterns and principles." },
        new SkillSet { Name = "Project Management", Shorthand = "Project Management", Description = "Experience with project management methodologies." },
        new SkillSet { Name = "Blockchain", Shorthand = "Blockchain", Description = "Knowledge of blockchain technology and its applications." },
        new SkillSet { Name = "Web3", Shorthand = "Web3", Description = "Familiarity with Web3 concepts and technologies." },
        new SkillSet { Name = "Game Development", Shorthand = "Game Dev", Description = "Experience with game development engines and tools." },
        new SkillSet { Name = "Mobile App Development", Shorthand = "Mobile Dev", Description = "Knowledge of mobile app development platforms and frameworks." },
        new SkillSet { Name = "Data Analysis", Shorthand = "Data Analysis", Description = "Experience with data analysis techniques and tools." },
        new SkillSet { Name = "Technical Writing", Shorthand = "Tech Writing", Description = "Ability to write clear and concise technical documentation." }
        ];

        private static List<Company> companiesSeedData =
        [
            new Company { CompanyName = "Vingroup", CompanyDescription = "Conglomerate with interests in real estate, retail, and technology", WebsiteURL = "www.vingroup.net", EstablishedYear = 1993, Country = "Vietnam", City = "Hanoi", Address = "Vincom Landmark 81, 720A Điện Biên Phủ, Phường 22, Bình Thạnh, Thành phố Hồ Chí Minh", NumberOfEmployees = 45000, ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/thumb/9/98/Vingroup_logo.svg/225px-Vingroup_logo.svg.png" },
            new Company { CompanyName = "Viettel", CompanyDescription = "Telecommunications company", WebsiteURL = "www.viettel.vn", EstablishedYear = 1989, Country = "Vietnam", City = "Hanoi", Address = "Số 1 Giang Văn Minh, Kim Mã, Ba Đình, Hà Nội", NumberOfEmployees = 40000, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Viettel_logo_2021.svg/300px-Viettel_logo_2021.svg.png" },
            new Company { CompanyName = "FPT Corporation", CompanyDescription = "Information technology and telecommunications company", WebsiteURL = "www.fpt.com.vn", EstablishedYear = 1988, Country = "Vietnam", City = "Hanoi", Address = "Tòa nhà FPT, phố Duy Tân, Cầu Giấy, Hà Nội", NumberOfEmployees = 37000, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/FPT_logo_2010.svg/330px-FPT_logo_2010.svg.png" },
            new Company { CompanyName = "Masan Group", CompanyDescription = "Conglomerate with interests in consumer goods, food, and beverages", WebsiteURL = "www.masan.vn", EstablishedYear = 1996, Country = "Vietnam", City = "Ho Chi Minh City", Address = "Tầng 18, Tòa nhà Lim Tower 2, 62A Cách Mạng Tháng Tám, Phường 6, Quận 3, Thành phố Hồ Chí Minh", NumberOfEmployees = 30000, ImageUrl = "https://cdn.dealstreetasia.com/uploads/2015/01/Vietnams_Masan_Group_restructures_consumer_biz.jpg?fit=620,346&resize=1920,undefined&q=75" },
            new Company { CompanyName = "Techcombank", CompanyDescription = "Commercial bank", WebsiteURL = "www.techcombank.com.vn", EstablishedYear = 1993, Country = "Vietnam", City = "Hanoi", Address = "191 Bà Triệu, Lê Đại Hành, Hai Bà Trưng, Hà Nội", NumberOfEmployees = 17000, ImageUrl = "https://tse3.mm.bing.net/th?id=OIP.e-QphJGA8CA6ciEiTJlZJgAAAA&pid=Api&P=0&h=180" },
            new Company { CompanyName = "Vinamilk", CompanyDescription = "Dairy company", WebsiteURL = "www.vinamilk.com.vn", EstablishedYear = 1976, Country = "Vietnam", City = "Ho Chi Minh City", Address = "10 Tân Trào, Tân Phú, Quận 7, Thành phố Hồ Chí Minh", NumberOfEmployees = 15000, ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.Uz9Cu__sY8fg6_vhBjETkQHaF_&pid=Api&P=0&h=180" },
            new Company { CompanyName = "Hoa Phat Group", CompanyDescription = "Steel and industrial manufacturing company", WebsiteURL = "www.hoaphat.com.vn", EstablishedYear = 1992, Country = "Vietnam", City = "Hanoi", Address = "Tòa nhà Hoa Phat, số 257 Giải Phóng, Thanh Xuân, Hà Nội", NumberOfEmployees = 28000, ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/thumb/9/98/Vingroup_logo.svg/225px-Vingroup_logo.svg.png" },
            new Company { CompanyName = "Vietnam Airlines", CompanyDescription = "National airline", WebsiteURL = "www.vietnamairlines.com", EstablishedYear = 1956, Country = "Vietnam", City = "Hanoi", Address = "200 Nguyễn Sơn, Bồ Đề, Long Biên, Hà Nội", NumberOfEmployees = 11000, ImageUrl = "https://logos-world.net/wp-content/uploads/2023/01/Vietnam-Airlines-Logo-2002.png" },
            new Company { CompanyName = "BIDV", CompanyDescription = "Commercial bank", WebsiteURL = "www.bidv.com.vn", EstablishedYear = 1957, Country = "Vietnam", City = "Hanoi", Address = "35 Hàng Vôi, Lý Thái Tổ, Hoàn Kiếm, Hà Nội", NumberOfEmployees = 25000, ImageUrl = "https://image.bnews.vn/MediaUpload/Org/2022/04/26/logo-bidv-20220426071253.jpg" },
            new Company { CompanyName = "Vietcombank", CompanyDescription = "Commercial bank", WebsiteURL = "www.vietcombank.com.vn", EstablishedYear = 1963, Country = "Vietnam", City = "Hanoi", Address = "198 Trần Quang Khải, Tràng Tiền, Hoàn Kiếm, Hà Nội", NumberOfEmployees = 23000, ImageUrl = "https://inkythuatso.com/uploads/images/2021/09/logo-vietcombank-inkythuatso-10-10-41-18.jpg" },
            new Company { CompanyName = "Google", CompanyDescription = "Search engine and technology giant", WebsiteURL = "www.google.com", EstablishedYear = 1998, Country = "USA", City = "Mountain View", Address = "1600 Amphitheatre Parkway", NumberOfEmployees = 186779, ImageUrl = "https://logosmarcas.net/wp-content/uploads/2020/09/Google-Logo.png" },
            new Company { CompanyName = "Microsoft", CompanyDescription = "Software and hardware company", WebsiteURL = "www.microsoft.com", EstablishedYear = 1975, Country = "USA", City = "Redmond", Address = "One Microsoft Way", NumberOfEmployees = 221000, ImageUrl = "https://techcrunch.com/wp-content/uploads/2016/03/microsoft.jpg" },
            new Company { CompanyName = "Amazon", CompanyDescription = "E-commerce and cloud computing company", WebsiteURL = "www.amazon.com", EstablishedYear = 1994, Country = "USA", City = "Seattle", Address = "410 Terry Ave N", NumberOfEmployees = 1608000, ImageUrl = "https://files.paredro.com/uploads/2018/08/Amazon-Logo.jpg" },
            new Company { CompanyName = "Apple", CompanyDescription = "Technology company known for its hardware and software", WebsiteURL = "www.apple.com", EstablishedYear = 1976, Country = "USA", City = "Cupertino", Address = "One Apple Park Way", NumberOfEmployees = 164000, ImageUrl = "https://static.vecteezy.com/system/resources/previews/019/136/328/non_2x/apple-logo-apple-icon-free-free-vector.jpg" },
            new Company { CompanyName = "Facebook (Meta)", CompanyDescription = "Social media company", WebsiteURL = "www.facebook.com", EstablishedYear = 2004, Country = "USA", City = "Menlo Park", Address = "1 Hacker Way", NumberOfEmployees = 86482, ImageUrl = "https://cdn.geeksandgamers.com/wp-content/uploads/hm_bbpui/247079/dj4dx2oh1ouh6zes56zdbo903o759383.jpg" },
            new Company { CompanyName = "Tesla", CompanyDescription = "Electric vehicle and clean energy company", WebsiteURL = "www.tesla.com", EstablishedYear = 2003, Country = "USA", City = "Austin", Address = "13101 Tesla Road", NumberOfEmployees = 127855, ImageUrl = "https://tse4.mm.bing.net/th?id=OIF.1Ge8cIz3rfl%2bsucX9NCN4w&pid=Api&P=0&h=180" },
            new Company { CompanyName = "Netflix", CompanyDescription = "Streaming service and production company", WebsiteURL = "www.netflix.com", EstablishedYear = 1997, Country = "USA", City = "Los Gatos", Address = "100 Winchester Circle", NumberOfEmployees = 12800, ImageUrl = "https://imgix.bustle.com/uploads/image/2017/8/29/c8c8077a-10fc-44d5-93f0-da4e592a299e-netflix-logo-print_pms.jpg?w=1200&h=630&fit=crop&crop=faces&fm=jpg" },
            new Company { CompanyName = "Samsung", CompanyDescription = "Electronics conglomerate", WebsiteURL = "www.samsung.com", EstablishedYear = 1938, Country = "South Korea", City = "Seoul", Address = "11, Seocho-daero 74-gil, Seocho-gu", NumberOfEmployees = 270000, ImageUrl = "https://blog.saginfotech.com/wp-content/uploads/2019/04/samsung-india-gst-investigation.jpg" },
            new Company { CompanyName = "Alibaba", CompanyDescription = "E-commerce and technology company", WebsiteURL = "www.alibaba.com", EstablishedYear = 1999, Country = "China", City = "Hangzhou", Address = "969 West Wen Yi Road, Yuhang District", NumberOfEmployees = 251462, ImageUrl = "https://tse1.mm.bing.net/th?id=OIP.7sn_MUIPWm1UCmv_A1VJtwHaHa&pid=Api&P=0&h=180" },
            new Company { CompanyName = "Tencent", CompanyDescription = "Technology and entertainment conglomerate", WebsiteURL = "www.tencent.com", EstablishedYear = 1998, Country = "China", City = "Shenzhen", Address = "Tencent Building, Kejizhongyi Avenue", NumberOfEmployees = 107600, ImageUrl = "https://tse3.mm.bing.net/th?id=OIP.XpYYkJNFEJJZkT9uwqAvNwHaEK&pid=Api&P=0&h=180" },
            new Company { CompanyName = "Walmart", CompanyDescription = "Retail corporation", WebsiteURL = "www.walmart.com", EstablishedYear = 1962, Country = "USA", City = "Bentonville", Address = "702 SW 8th Street", NumberOfEmployees = 2300000, ImageUrl = "https://elceo.com/wp-content/uploads/2019/02/walmart_001.jpg" },
            new Company { CompanyName = "Toyota", CompanyDescription = "Automotive manufacturer", WebsiteURL = "www.toyota.com", EstablishedYear = 1937, Country = "Japan", City = "Toyota", Address = "1 Toyota-cho", NumberOfEmployees = 372817, ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.7-JWg05VBRPqwUB6uFHRjgHaEK&pid=Api&P=0&h=180" },
            new Company { CompanyName = "Berkshire Hathaway", CompanyDescription = "Multinational conglomerate", WebsiteURL = "www.berkshirehathaway.com", EstablishedYear = 1839, Country = "USA", City = "Omaha", Address = "3555 Farnam Street", NumberOfEmployees = 372000, ImageUrl = "https://tse1.mm.bing.net/th?id=OIF.RdG1wAe0rSPJr4TtYBe85g&pid=Api&P=0&h=180" },
            new Company { CompanyName = "JPMorgan Chase & Co.", CompanyDescription = "Financial services company", WebsiteURL = "www.jpmorganchase.com", EstablishedYear = 2000, Country = "USA", City = "New York City", Address = "383 Madison Avenue", NumberOfEmployees = 293723, ImageUrl = "https://logos-world.net/wp-content/uploads/2021/02/JP-Morgan-Chase-Emblem.png" },
            new Company { CompanyName = "Johnson & Johnson", CompanyDescription = "Pharmaceutical and consumer goods company", WebsiteURL = "www.jnj.com", EstablishedYear = 1886, Country = "USA", City = "New Brunswick", Address = "One Johnson & Johnson Plaza", NumberOfEmployees = 141700, ImageUrl = "https://logo-marque.com/wp-content/uploads/2020/09/Johnson-Johnson-Symbole.png" },
            new Company { CompanyName = "ExxonMobil", CompanyDescription = "Oil and gas company", WebsiteURL = "www.exxonmobil.com", EstablishedYear = 1999, Country = "USA", City = "Irving", Address = "5959 Las Colinas Boulevard", NumberOfEmployees = 63000, ImageUrl = "https://veja.abril.com.br/wp-content/uploads/2020/12/ExxonMobil.jpg" },
            new Company { CompanyName = "Nestle", CompanyDescription = "Food and beverage company", WebsiteURL = "www.nestle.com", EstablishedYear = 1866, Country = "Switzerland", City = "Vevey", Address = "Avenue Nestlé 55", NumberOfEmployees = 273000, ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.wiEfKBvGyDA0nvwKcmdhRQHaEe&pid=Api&P=0&h=180" },
            new Company { CompanyName = "McDonald's", CompanyDescription = "Fast food chain", WebsiteURL = "www.mcdonalds.com", EstablishedYear = 1940, Country = "USA", City = "Chicago", Address = "110 N. Carpenter Street", NumberOfEmployees = 200000, ImageUrl = "http://restauranttechnologynews.com/wp-content/uploads/2022/12/mcdonalds-texas.jpg" },
            new Company { CompanyName = "Coca-Cola", CompanyDescription = "Beverage company", WebsiteURL = "www.coca-colacompany.com", EstablishedYear = 1886, Country = "USA", City = "Atlanta", Address = "One Coca-Cola Plaza", NumberOfEmployees = 79000, ImageUrl = "https://cafebiz.cafebizcdn.vn/thumb_w/600/162123310254002176/2022/7/19/photo1658221814822-1658221814942834787821.jpg#force-thumb" },
            new Company { CompanyName = "Disney", CompanyDescription = "Entertainment and media conglomerate", WebsiteURL = "www.thewaltdisneycompany.com", EstablishedYear = 1923, Country = "USA", City = "Burbank", Address = "500 South Buena Vista Street", NumberOfEmployees = 223000, ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.7iCj0yZ9eH3B6vZROuT5QQHaDJ&pid=Api&P=0&h=180" }
        ];

        private static List<BusinessStream> businessStreamsSeedData =
        [
            new BusinessStream { BusinessStreamName = "E-commerce", Description = "Buying and selling goods and services online." },
            new BusinessStream { BusinessStreamName = "Fintech", Description = "Financial technology, encompassing online banking, mobile payments, and investment platforms." },
            new BusinessStream { BusinessStreamName = "Edtech", Description = "Educational technology, including online learning platforms, educational apps, and e-learning solutions." },
            new BusinessStream { BusinessStreamName = "Healthtech", Description = "Healthcare technology, such as telemedicine, electronic health records, and health monitoring devices." },
            new BusinessStream { BusinessStreamName = "Agritech", Description = "Agricultural technology, focusing on precision farming, farm management software, and agricultural drones." },
            new BusinessStream { BusinessStreamName = "Software Development", Description = "Creating and maintaining software applications, websites, and other software components." },
            new BusinessStream { BusinessStreamName = "IT Services", Description = "Providing IT support, consulting, and outsourcing services." },
            new BusinessStream { BusinessStreamName = "Digital Marketing", Description = "Promoting products and services online through search engine optimization, social media marketing, and content marketing." },
            new BusinessStream { BusinessStreamName = "E-logistics", Description = "Technology-driven logistics solutions for e-commerce and supply chain management." },
            new BusinessStream { BusinessStreamName = "Cybersecurity", Description = "Protecting computer systems and networks from cyber threats and data breaches." },
            new BusinessStream { BusinessStreamName = "Artificial Intelligence (AI)", Description = "Developing and implementing AI algorithms for various applications, including machine learning, natural language processing, and computer vision." },
            new BusinessStream { BusinessStreamName = "Blockchain", Description = "Utilizing blockchain technology for secure transactions, data management, and decentralized applications." },
            new BusinessStream { BusinessStreamName = "Cloud Computing", Description = "Providing cloud-based services, such as data storage, computing power, and software applications." },
            new BusinessStream { BusinessStreamName = "Internet of Things (IoT)", Description = "Connecting devices and objects to the internet to collect and exchange data." },
            new BusinessStream { BusinessStreamName = "Big Data Analytics", Description = "Analyzing large datasets to extract insights and improve decision-making." },
            new BusinessStream { BusinessStreamName = "Game Development", Description = "Creating and developing video games for various platforms." },
            new BusinessStream { BusinessStreamName = "Mobile App Development", Description = "Developing mobile applications for iOS and Android devices." },
            new BusinessStream { BusinessStreamName = "Web Development", Description = "Designing and developing websites and web applications." },
            new BusinessStream { BusinessStreamName = "Data Science", Description = "Extracting knowledge and insights from data using scientific methods, algorithms, and systems." },
            new BusinessStream { BusinessStreamName = "UI/UX Design", Description = "Designing user interfaces and user experiences for websites and applications." }
        ];
    }
}
