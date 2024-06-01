using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Campaign
{
    public class CampaignRequest
    {
        public string Name { get; set; }
        public string ScopeOfWork { get; set; }
        public string Requirements { get; set; }
        public int Duration { get; set; }
        public List<int> TrainingProgramIds { get; set; }
        public string? ImagePath { get; set; }
    }
}
