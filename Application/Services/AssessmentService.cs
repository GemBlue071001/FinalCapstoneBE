using Application.Interface;
using Application.Request.Assessment;
using Application.Response;
using Application.Response.Assessment;
using Application.Response.Campaign;
using Application.Response.Job;
using AutoMapper;
using Domain.Entities;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssessmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddAssessment(AssessmentRequest request)
        {
            var response = new ApiResponse();

            var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == request.UserId);
            if (user == null)
            {
                return response.SetBadRequest("User not found !!");
            }

            var assessment = _mapper.Map<Assessment>(request);
            await _unitOfWork.Assessment.AddAsync(assessment);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public Task<ApiResponse> GetAllAssessment()
        {
            throw new NotImplementedException();
        }
    }
}
