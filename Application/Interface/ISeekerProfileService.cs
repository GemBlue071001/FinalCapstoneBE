using Application.Request.SeekerProfile;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ISeekerProfileService
    {
        Task<ApiResponse> AddNewSeekerProfilesAsync(SeekerProfileRequest seekerProfileRequest);
        Task<ApiResponse> GetAllSeekerProfileAsync();
        Task<ApiResponse> DeletedSeekerProfileByIdAsync(int id);
    }
}
