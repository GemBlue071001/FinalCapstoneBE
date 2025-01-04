using Application.Request.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IUserAccountRepository : IGenericRepository<UserAccount>
    {
        Task<List<UserAccount>> FindTalent(FindTalentRequest request);
        Task<int> CountTotalPaging(FindTalentRequest request);
    }
}
