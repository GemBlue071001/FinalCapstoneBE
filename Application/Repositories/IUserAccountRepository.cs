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
        Task<List<TrainingProgram>> GetTrainingProgramsByUserId(int userId);
    }
}
