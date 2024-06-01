using Application.Repositories;
using Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUnitOfWork
    {
        public IUserAccountRepository UserAccounts { get; }
        public ITrainingProgramRepository TrainingPrograms { get; }
        public ICandidateRepository Candidates { get; }
        public ICampaignTrainingProgramRepository CampaignTrainingPrograms { get; }
        public ICampaignRepository Campaigns { get; }
        public Task SaveChangeAsync();
    }
}
