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
        public IJobRepository Jobs { get; }
        public ICandidateRepository Candidates { get; }
        public ICampaignJobRepository CampaignJobs { get; }
        public ICampaignRepository Campaigns { get; }
        public ITrainingProgramRepository TrainingPrograms { get; }
        public IAssessmentRepository Assessment { get; }
        public Task SaveChangeAsync();
    }
}
