using Application.Request.UserJobAlertCriteria;
using Application.Response;

namespace Application.Interface
{
    public interface IUserJobAlertCriteriaService
    {
        Task<ApiResponse> AddNewAlertCriteriaAsync(UserJobAlertCriteriaRequest criteriaRequest);
        Task<ApiResponse> GetAllAlertCriteriaAsync(int userId);
        Task<ApiResponse> DeleteAlertCriteriaByIdAsync(int id);
    }
}
