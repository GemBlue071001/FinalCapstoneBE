using Application.Request.Campaign;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICampaignService
    {
        Task<ApiResponse> AddCampaign(CampaignRequest request);
        Task<ApiResponse> GetAllCampaign();
        Task<ApiResponse> DeleteCampaign(int id);
        Task<ApiResponse> UpdateCampainAsync(UpdateCampainRequest request);
        Task<ApiResponse> AddJobToCampaignAsync(CampaignJobRequest request);
        Task<ApiResponse> RemoveJobFromCampaignAsync(CampaignJobRequest request);
    }
}
