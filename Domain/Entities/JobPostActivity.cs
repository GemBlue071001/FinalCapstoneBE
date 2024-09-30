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

        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public JobPost JobPost { get; set; }
        public int UserId { get; set; }
        public int JobPostId { get; set; }
    }

    public enum JobPostActivityStatus
    {
        Applied=0,
        Pending=1,
        Rejected=2,
        Passed=3,
    }
}
