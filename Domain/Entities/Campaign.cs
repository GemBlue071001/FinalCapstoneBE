using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Campaign: Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ScopeOfWork { get; set; }
        public string? Requirements { get; set; }
        public string? Benefits { get; set; }
        public int Duration { get; set; }
        public string? ImagePath { get; set; }
        public DateTime EstimateStartDate { get; set; }
        public DateTime EstimateEndDate { get; set; }


        public List<CampaignJob> CampaignJobs { get; set; }

    }
}
