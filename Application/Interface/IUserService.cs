using Application.Request.User;
using Application.Response;

namespace Application.Interface
{
    public interface IUserService
    {
        Task<ApiResponse> GetUserJobPostActivity();
        Task<ApiResponse> UpdateUserAsync(UpdateUserRequest request);
        Task<ApiResponse> AddEmployerToCompany(AddEmployerToCompanyRequest request);
        Task<ApiResponse> GetUserProfileAsync(int id);
        Task<ApiResponse> AddSkillSetToUser(SeekerSkillSetRequest request);
        Task<ApiResponse> RemoveSkillSetToUser(SeekerSkillSetRequest request);
        Task<ApiResponse> GetAllJobSeekerRoleAsync(int pageIndex, int pageSize, int jobPostId);
        Task<ApiResponse> AddBenefitToUser(SeekerBenefitRequest request);
        Task<ApiResponse> RemoveBenefitToUser(SeekerBenefitRequest request);
        Task<ApiResponse> FindTalentAsync(FindTalentRequest findTalentRequest);
    }
}
