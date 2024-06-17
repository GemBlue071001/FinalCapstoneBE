
using Application.Request.Assessment;
using Application.Request.TrainingProgram;
using Application.Response;

namespace Application.Interface
{
    public interface IAssessmentService
    {
        Task<ApiResponse> AddAssessment(AssessmentRequest request);
        Task<ApiResponse> GetAllAssessment();
    }
}
