
using Application.Interface;
using Application.Request.BusinessStream;
using Application.Response;
using Application.Response.BusinessStream;
using Application.Response.SkillSet;
using AutoMapper;
using Domain.Entities;


namespace Application.Services
{
    public class BusinessStreamService : IBusinessStreamService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        public BusinessStreamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddNewBusinessStreamAsync(BusinessStreamRequest businessStreamRequest)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var businessStream = _mapper.Map<BusinessStream>(businessStreamRequest);
                await _unitOfWork.BusinessStreams.AddAsync(businessStream);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk("Create Success");
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
        public async Task<ApiResponse> GetAllBusinessStreamAsync()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var businessStreams = await _unitOfWork.BusinessStreams.GetAllAsync(null);
                var businessStreamsResponse = _mapper.Map<List<BusinessStreamResponse>>(businessStreams);
                return new ApiResponse().SetOk(businessStreamsResponse);
            }
            catch (Exception ex)
            {
                return apiResponse.SetBadRequest(ex.Message);
            }
        }
    }
}
