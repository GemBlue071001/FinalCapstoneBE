
using Application.Request.Assessment;
using Application.Request.TrainingProgram;
using Application.Response;

namespace Application.Interface
{
    public interface IAssessmentService
    {
        Task<ApiResponse> AddAssessmentAsync(AssessmentRequest request);
        Task<ApiResponse> GetAllAssessmentAsync(int programId);
        Task<ApiResponse> DeleteAssessmentAsync(int id);
        Task<ApiResponse> UpdateAssessmentAsync(AssessmentUpdateRequest request);
        Task<ApiResponse> AsignAssessmentToProgramAsync(ProgramAssessmentRequest request);
        Task<ApiResponse> UpdateAssessmentStatusAsync(AssessmentUpdateStatusRequest request);
        Task<ApiResponse> GradeAssessmentAsync(GradeAssessmentRequest request);
    }
}
