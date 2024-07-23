using Application.Request.Candidate;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICandidateService
    {
        Task<ApiResponse> AddCadidate(CandidateRequest request);
        Task<ApiResponse> GetProgramCadidate(int campaignId, int jobId);
        Task<ApiResponse> GetUserAplication();
        Task<ApiResponse> UpdateCandidateAsync(CandidateUpdateRequest request);
        Task<ApiResponse> DeleteCandidateAsync(int id);
    }
}
