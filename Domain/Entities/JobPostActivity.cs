using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobPostActivity:Base
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public JobPostActivityStatus Status { get; set; }
        public double? Score { get; set; }

        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public JobPost JobPost { get; set; }
        public string AnalyzedResult { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public int? JobPostId { get; set; }
        public CV CV { get; set; }
        public int? CvId { get; set; }
        public List<Notification>? Notifications { get; set; }
        public List<JobPostActivityComment>? JobPostActivityComments { get; set; }
    }

    public enum JobPostActivityStatus
    {
        Applied=0,
        Pending=1,
        Rejected=2,
        Passed=3,
        CVScreeningPassed = 4,
        InterviewStage = 5,
    }
}
