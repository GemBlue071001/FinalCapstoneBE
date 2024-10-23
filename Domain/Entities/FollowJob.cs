using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FollowJob
    {
        public int Id { get; set; }
        public UserAccount UserAccount { get; set; }
        public int UserId { get; set; }
        public JobPost JobPost { get; set; }
        public int JobPostId { get; set; }
    }
}
