using Application;
using Application.Repositories;
using Application.Repository;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public IUserAccountRepository UserAccounts { get; }
        public ITrainingProgramRepository TrainingPrograms { get; }
        public ICandidateRepository Candidates { get; }
        public ICampaignTrainingProgramRepository CampaignTrainingPrograms { get; }
        public ICampaignRepository Campaigns { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserAccounts = new UserAccountRepository(context);
            TrainingPrograms = new TrainingProgramRepository(context);
            Candidates = new CandidateRepository(context);
            CampaignTrainingPrograms = new CampaignTrainingProgramRepository(context);
            Campaigns = new CampaignRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
