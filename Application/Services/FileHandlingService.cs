﻿using Application.Interface;
using Application.MyMapper;
using Application.Request.CV;
using Application.Response;
using Application.Response.AnalyzedResult;
using Application.Response.JobPost;
using ClosedXML.Excel;
using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Application.Services
{
    public class FileHandlingService : IFileHandlingService
    {
        private IJobPostService _jobPostService;
        private IClaimService _claimService;
        private IUnitOfWork _unitOfWork;
        private readonly ApiSettings _apiSettings;
        public FileHandlingService(IJobPostService jobPostService, IClaimService claimService, IUnitOfWork unitOfWork, IOptions<AppSettings> appSettings)
        {
            _jobPostService = jobPostService;
            _claimService = claimService;
            _unitOfWork = unitOfWork;
            _apiSettings = appSettings.Value.ApiSettings;
        }
        public async Task<ApiResponse> ImportExcel(IFormFile file)
        {
            ApiResponse apiResponse = new ApiResponse();
            if (file == null || file.Length == 0)
            {
                return apiResponse.SetBadRequest("File is empty");
            }
            List<JobPost> jobPosts = new List<JobPost>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var workbook = new XLWorkbook(stream))
                {
                    var worksheet = workbook.Worksheet(1); // First worksheet
                    var rows = worksheet.RangeUsed().RowsUsed();

                    foreach (var row in rows.Skip(1)) // Skip header row
                    {
                        //var record = new JobPost
                        //{
                        //    JobTitle = row.Cell(1).GetValue<string>(),
                        //    Salary = row.Cell(2).GetValue<decimal>(),
                        //    JobType = row.Cell(3).GetValue<JobType>(),
                        //    Company = row.Cell(4).GetValue<Company>(),

                        //    // Add more properties as needed
                        //};
                        //jobPosts.Add(record);
                        var a = row.Cell(1).GetValue<string>();
                    }
                }
            }
            return apiResponse.SetOk("Success");

        }


        public async Task<ApiResponse> UploadCVToAnalyze(string firebasePdfUrl, int jobId, int cvId, int userId)
        {
            using (var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(360) })
            {
                try
                {
                    var userClaim = _claimService.GetUserClaim();
                    var applicant = await _unitOfWork.JobPostActivities.GetAsync(x => x.UserId == userId && x.JobPostId == jobId);
                    if (!string.IsNullOrEmpty(applicant.AnalyzedResult))
                    {
                        return new ApiResponse().SetOk(applicant.AnalyzedResult);
                    }

                    ExtractedCVData cvData = new ExtractedCVData();
                    var cv = await _unitOfWork.CVs.GetAsync(x => x.Id == cvId);


                    if (cv != null && !string.IsNullOrEmpty(cv.ExtractedInfo))
                    {
                        cvData = JsonConvert.DeserializeObject<ExtractedCVData>(cv.ExtractedInfo);
                    }
                    else
                    {
                        var fileStream = await httpClient.GetStreamAsync(firebasePdfUrl);
                        var streamContent = new StreamContent(fileStream);
                        streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                        var formData = new MultipartFormDataContent
                        {
                            { streamContent, "file", "document.pdf" },
                        };

                        var response = await httpClient.PostAsync($"{_apiSettings.RootServerUrl}{_apiSettings.UpLoadAndProcess}", formData);

                        if (!response.IsSuccessStatusCode)
                        {
                            return new ApiResponse().SetBadRequest($"Error from API: {response.ReasonPhrase}");
                        }

                        var responseData = await response.Content.ReadAsStringAsync();
                        var analysisResult = JsonConvert.DeserializeObject<CVAnalysisResponse>(responseData);

                        // Map the response to the UploadCVJsonRequest
                        var cvMapper = new CVMapper();
                        cvData = cvMapper.MapToCVJsonRequest(analysisResult);
                    }

                    var secondApiResponse = await UploadCVAsync(cvData);

                    var jobpostResponse = await _jobPostService.GetJobPostById(jobId);
                    var jobPostApiUploadResponse = await UploadJobPost((JobPostResponse)jobpostResponse.Result);

                    var result = await AnalyzeMatch();

                    applicant.AnalyzedResult = result;
                    await _unitOfWork.SaveChangeAsync();

                    return new ApiResponse().SetOk(result);
                }
                catch (HttpRequestException ex)
                {
                    return new ApiResponse().SetBadRequest($"HTTP request error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    return new ApiResponse().SetBadRequest($"Unexpected error: {ex.Message}");
                }
            }
        }

        private async Task<string> UploadCVAsync(ExtractedCVData request)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonRequestBody = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"{_apiSettings.RootServerUrl}{_apiSettings.UpLoadCv}", content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error from 1st API: {response.ReasonPhrase}");
                }

                return await response.Content.ReadAsStringAsync();
            }
        }

        private async Task<string> UploadJobPost(JobPostResponse request)
        {
            // Map request to ensure it matches the structure of the successful JSON
            var mappedRequest = new
            {
                id = request.Id,
                jobTitle = request.JobTitle,
                jobDescription = request.JobDescription,
                salary = (int)request.Salary, // Ensure salary is an integer
                postingDate = request.PostingDate.ToString("o"), // Format as ISO 8601
                expiryDate = request.ExpiryDate.ToString("o"), // Format as ISO 8601
                experienceRequired = request.ExperienceRequired,
                qualificationRequired = request.QualificationRequired,
                benefits = request.Benefits,
                imageURL = request.ImageURL,
                isActive = request.IsActive,
                companyId = request.CompanyId,
                companyName = request.CompanyName,
                websiteCompanyURL = request.WebsiteCompanyURL,
                jobType = new
                {
                    id = request.JobType.Id,
                    name = request.JobType.Name,
                    description = request.JobType.Description
                },
                jobLocationCities = request.JobLocationCities ?? new List<string>(),
                jobLocationAddressDetail = request.JobLocationAddressDetail ?? new List<string>(),
                skillSets = request.SkillSets ?? new List<string>()
            };

            using (var httpClient = new HttpClient())
            {
                string jsonRequestBody = JsonConvert.SerializeObject(mappedRequest);
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"{_apiSettings.RootServerUrl}{_apiSettings.UpLoadJob}", content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error from second API: {response.ReasonPhrase}");
                }

                return await response.Content.ReadAsStringAsync();
            }
        }

        private async Task<string> AnalyzeMatch()
        {
            using (var httpClient = new HttpClient())
            {

                var response = await httpClient.PostAsync($"{_apiSettings.RootServerUrl}{_apiSettings.AnalyzeMatch}", null);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error from 3rd API: {response.ReasonPhrase}");
                }

                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}
