using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainingProgram : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ScopeOfWork { get; set; }
        public string? Requirements { get; set; }
        public string? Benefits { get; set; }
        public DateTime? StartDate { get; set; }
        public int Duration { get; set; }
        public int TotalMember { get; set; }
        public string? ImagePath { get; set; }

        public List<CampaignTrainingProgram> CampaignTrainingPrograms { get; set; }
        public List<UserAccount> Interns { get; set; }
        public List<Candidate> Candidates { get; set; }

    }
}
