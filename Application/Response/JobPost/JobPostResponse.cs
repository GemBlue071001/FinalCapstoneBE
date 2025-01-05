using Application.Response.Benefit;
using Application.Response.JobType;
using Application.Response.Location;
using Application.Response.SkillSet;
using Pgvector;

namespace Application.Response.JobPost
{
    public class JobPostResponse
    {
        public int Id { get; set; }
        public string Link => $"https://jobsearch-zeta-nine.vercel.app/jobs/detail/{Id}";
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal Salary { get; set; }
        public decimal Minsalary { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ExperienceRequired { get; set; }
        public string QualificationRequired { get; set; }
        public string Benefits { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActive { get; set; }
        public bool IsHot { get; set; }
        public Vector? Embedding { get; set; }
        //public UserResponse User { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteCompanyURL { get; set; }
        public JobTypeResponse JobType { get; set; }
        public List<string> JobLocationCities { get; set; }
        public List<string> JobLocationAddressDetail { get; set; }
        public List<string> SkillSets { get; set; }
        public List<SkillSetResponse> SkillSetObjects { get; set; }
        public List<BenefitResponse> BenefitObjects { get; set; }
        public List<LocationResponse> LocationObjects { get; set; }
    }
}
