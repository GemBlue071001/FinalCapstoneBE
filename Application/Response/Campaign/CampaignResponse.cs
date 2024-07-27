using Application.Response.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.Campaign
{
    public class CampaignResponse
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
        public DateTime SubmissionDeadline { get; set; }


        public List<JobResponse> Jobs { get; set; }
    }
}
