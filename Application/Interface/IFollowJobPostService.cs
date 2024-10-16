using Application.Request.FollowJob;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IFollowJobPostService
    {
        Task<ApiResponse> AddFollowJobPostAsync(FollowJobRequest followJobRequest);
        Task<ApiResponse> GetFollowJobPostAsync();
        Task<ApiResponse> DeleteFollowJobPostById(int id);
    }
}
