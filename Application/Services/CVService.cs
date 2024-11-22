using Application.Interface;
using Application.Request.CV;
using Application.Request.EducationDetail;
using Application.Response;
using Application.Response.AnalyzedResult;
using Application.Response.CV;
using AutoMapper;
using Domain;
using Domain.Entities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CVService : ICVService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;
        private readonly ApiSettings _apiSettings;
        public CVService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService, IOptions<AppSettings> appSettings)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
            _apiSettings = appSettings.Value.ApiSettings;
        }
        public async Task<ApiResponse> AddNewCVAsync(CVRequest request)
        {
            try
            {
                var claim = _claimService.GetUserClaim();
                var cv = _mapper.Map<CV>(request);
                cv.UserId = claim.Id;
                var extractedInfo = await AnalyzeCVAsync(request.Url);
                if (string.IsNullOrEmpty(extractedInfo))
                {
                    return new ApiResponse().SetBadRequest("Failed to extract CV information.");
                }
                cv.ExtractedInfo = extractedInfo;
                await _unitOfWork.CVs.AddAsync(cv);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("CV has been added and analyzed successfully!");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetCVListAsync()
        {
            var claim = _claimService.GetUserClaim();
            var cvs = await _unitOfWork.CVs.GetAllAsync(x => x.UserId == claim.Id);
            var responseList = _mapper.Map<List<CVResponse>>(cvs);

            return new ApiResponse().SetOk(responseList);
        }
        public async Task<ApiResponse> DeletedCvByIdAsync(int id)
        {
            try
            {
                var claim = _claimService.GetUserClaim();
                var cv = await _unitOfWork.CVs.GetAsync(x => x.UserId == claim.Id && x.Id == id);
                if (cv == null)
                {
                    return new ApiResponse().SetNotFound("CV not found or you do not have permission to delete this CV.");
                }
                await _unitOfWork.CVs.RemoveByIdAsync(cv.Id);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("CV deleted successfully!");

            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
            
        }
        private async Task<string> AnalyzeCVAsync(string fileUrl)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                   
                    var formData = new MultipartFormDataContent();
                    formData.Add(new StringContent(fileUrl), "fileUrl");

                    var response = await httpClient.PostAsync($"{_apiSettings.RootServerUrl}{_apiSettings.UpLoadAndProcess}", formData);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException($"Error from Analyze API: {response.ReasonPhrase}");
                    }
                    var responseData = await response.Content.ReadAsStringAsync();
                    var analysisResult = JsonConvert.DeserializeObject<CVAnalysisResponse>(responseData);
                    return JsonConvert.SerializeObject(analysisResult);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Failed to analyze CV: {ex.Message}");
                }
            }
        }
    }
}
