using Application.Interface;
using Application.Request.Assessment;
using Application.Response;
using Application.Response.Assessment;
using Application.Response.Campaign;
using Application.Response.Job;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ApiResponse> AddAssessmentAsync(AssessmentRequest request)
        {
            var response = new ApiResponse();

            var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == request.UserId);
            if (user == null)
            {
                return response.SetBadRequest("User not found !!");
            }

            var assessment = _mapper.Map<Assessment>(request);
            assessment.Status = "";
            await _unitOfWork.Assessment.AddAsync(assessment);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetAllAssessmentAsync(int programId)
        {
            var response = new ApiResponse();
            List<Assessment> assessments;
            if (programId != 0)
            {
                assessments = await _unitOfWork.Assessment.GetAllAsync(x => x.TrainingProgramId == programId,
                                                                       x => x.Include(x => x.Owner).Include(x => x.AssessmentSubmitions));
            }

            else
            {
                assessments = await _unitOfWork.Assessment.GetAllAsync(null,
                                                                      x => x.Include(x => x.Owner).Include(x => x.AssessmentSubmitions));
            }

            var responseList = _mapper.Map<List<AssessmentResponse>>(assessments);
            return response.SetOk(responseList);
        }

        public async Task<ApiResponse> DeleteAssessmentAsync(int id)
        {
            var response = new ApiResponse();
            var assessment = await _unitOfWork.Assessment.GetAsync(u => u.Id == id);
            if (assessment == null)
            {
                return response.SetBadRequest("assessment not found");
            }
            await _unitOfWork.Assessment.RemoveByIdAsync(id);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(assessment);
        }

        public async Task<ApiResponse> UpdateAssessmentAsync(AssessmentUpdateRequest request)
        {
            var response = new ApiResponse();
            var assessment = await _unitOfWork.Assessment.GetAsync(u => u.Id == request.Id);
            if (assessment == null)
            {
                return response.SetBadRequest("assessment not found");
            }
            _mapper.Map(request, assessment);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(assessment);
        }

        public async Task<ApiResponse> AsignAssessmentToProgramAsync(ProgramAssessmentRequest request)
        {
            var response = new ApiResponse();
            var assessment = await _unitOfWork.Assessment.GetAsync(u => u.Id == request.AssessmentId);
            if (assessment == null)
            {
                return response.SetBadRequest("assessment not found");
            }
            var program = await _unitOfWork.TrainingPrograms.GetAsync(u => u.Id == request.TrainingProgramId);
            if (program == null)
            {
                return response.SetBadRequest("program not found");
            }

            assessment.TrainingProgramId = request.TrainingProgramId;
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Success");
        }
        public async Task<ApiResponse> UpdateAssessmentStatusAsync(AssessmentUpdateStatusRequest request)
        {
            var response = new ApiResponse();
            var assessment = await _unitOfWork.Assessment.GetAsync(a => a.Id == request.Id);
            if (assessment == null)
            {
                return response.SetBadRequest("Assessment not found");
            }

            switch (request.Status)
            {
                case AssessmentStatus.Pending:
                    assessment.StartDate = DateTime.UtcNow;
                    assessment.AssessmentStatus = AssessmentStatus.Pending;
                    break;
                case AssessmentStatus.Completed:
                    assessment.EndDate = DateTime.UtcNow;
                    assessment.AssessmentStatus = AssessmentStatus.Completed;
                    break;
                default:
                    return response.SetBadRequest("Invalid status");
            }
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("Success");
        }
    }
}
