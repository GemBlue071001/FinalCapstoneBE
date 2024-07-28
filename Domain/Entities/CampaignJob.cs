using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CampaignJob
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int JobId { get; set; }

       
        public Job Job { get; set; }
        public Campaign Campaign { get; set; }

        public List<UserAccount> Interns { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}
