using Application.Request.SkillSet;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ISkillSetService
    {
        Task<ApiResponse> AddNewSkillSet(SkillSetRequest skillSetRequest);
        Task<ApiResponse> GetAllSkillSetAsync();
        Task<ApiResponse> DeletedSkillSetByIdAsync(int id);
    }
}
