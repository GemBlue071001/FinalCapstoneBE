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
        public IJobTrainingProgramRepository JobTrainingPrograms { get; }
        public ICandidateRepository Candidates { get; }
        public ICampaignJobRepository CampaignJobs { get; }
        public ICampaignRepository Campaigns { get; }
        public ITrainingProgramRepository TrainingPrograms { get; }
        public IAssessmentRepository Assessment { get; }
        public IResourceRepository Resources { get; }
        public ITrainingProgramResourceRepository TrainingProgramResources { get; }
        public IUserMeetingRepository UserMeetings { get; }
        public IMeetingRepository Meetings { get; }
        public IKPIRepository KPIs { get; }
        public IProgramKPIRepository ProgramKPIs { get; }
        public IUserResultRepository UserResults { get; }
        public IAssessmentSubmitionsRepository AssessmentSubmitions { get; }
        public IConversationRepository Conversations { get; }
        public IMessageRepository Messages { get; }
        public Task SaveChangeAsync();
    }
}
