using Application.Interface;
using Application.MyMapper;
using Application.Request.CV;
using Application.Response;
using Application.Response.AnalyzedResult;
using Application.Response.CV;
using AutoMapper;
using Domain;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
namespace Application.Services
{
    public class CVService : ICVService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;
        private readonly ApiSettings _apiSettings;
        private readonly IServiceProvider _serviceProvider;

        public CVService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService, IOptions<AppSettings> appSettings, IServiceProvider serviceProvider)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
            _apiSettings = appSettings.Value.ApiSettings;
            _serviceProvider = serviceProvider;
        }

        public async Task ResetCvdSequenceAsync()
        {
            // Get the sequence name for the CVs.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"CVs\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the CVs table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"CVs\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> AddNewCVAsync(CVRequest request)
        {
            try
            {
                await ResetCvdSequenceAsync();
                var claim = _claimService.GetUserClaim();
                var cv = _mapper.Map<CV>(request);
                cv.UserId = claim.Id;
                //cv.ExtractedInfo = extractedInfo;
                await _unitOfWork.CVs.AddAsync(cv);
                await _unitOfWork.SaveChangeAsync();

                _ = Task.Run(async () =>
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        try
                        {
                            var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                            var cvService = scope.ServiceProvider.GetRequiredService<ICVService>();

                            // Use a new scope to analyze the CV
                            await cvService.AnalyzeCVAsync(request.Url, cv.Id);
                        }
                        catch (Exception ex)
                        {
                            // Log or handle the exception as needed
                            Console.WriteLine($"Background task failed: {ex.Message}");
                        }
                    }
                });

                return new ApiResponse().SetOk("CV has been added successfully!");
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
        
        
        public async Task<string?> AnalyzeCVAsync(string fileUrl, int cvId)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var fileStream = await httpClient.GetStreamAsync(fileUrl);

                    // Step 2: Create StreamContent from the downloaded PDF
                    var streamContent = new StreamContent(fileStream);
                    streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

                    // Step 3: Create FormData and append the file and jobId
                    var formData = new MultipartFormDataContent
                    {
                        { streamContent, "file", "document.pdf" },
                    };

                    // Step 4: Send the POST request to the API endpoint
                    var response = await httpClient.PostAsync($"{_apiSettings.RootServerUrl}{_apiSettings.UpLoadAndProcess}", formData);

                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    var responseData = await response.Content.ReadAsStringAsync();
                    var analysisResult = JsonConvert.DeserializeObject<CVAnalysisResponse>(responseData);

                    // Map the response to the UploadCVJsonRequest
                    var cvMapper = new CVMapper();
                    var cvData = cvMapper.MapToCVJsonRequest(analysisResult);
                    var cv = await _unitOfWork.CVs.GetAsync(x => x.Id == cvId);
                    cv.ExtractedInfo = JsonConvert.SerializeObject(cvData);
                    await _unitOfWork.SaveChangeAsync();

                    return cv.ExtractedInfo;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Failed to analyze CV: {ex.Message}");
                }
            }
        }
    }
}
