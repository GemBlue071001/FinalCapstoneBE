using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Candidate : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string CVPath {  get; set; } = string.Empty;
        public CandidateStatus CandidateStatus { get; set; } = CandidateStatus.Applied;


        //Navigation Property
        public int? UserId { get; set; }
        public UserAccount? User {  get; set; }
        public CampaignJob? CampaignJob { get; set; }
        public int? CampaignJobId { get; set; }
    }

    public enum CandidateStatus
    {
        Applied,
        InterviewScheduled,
        Interviewed,
        Accepted,
        Declined,
    }
}
