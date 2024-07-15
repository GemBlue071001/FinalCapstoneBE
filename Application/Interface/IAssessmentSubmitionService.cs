using Application.Request.AssessmentSubmition;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IAssessmentSubmitionService
    {
        Task<ApiResponse> AddSubmitionAsync(SubmitionRequest request);
        Task<ApiResponse> GetAllSubmitionByAsseessmentAsync(int asseessmentId);
        Task<ApiResponse> RemoveSubmitionAsync(int submitionId);
    }
}
