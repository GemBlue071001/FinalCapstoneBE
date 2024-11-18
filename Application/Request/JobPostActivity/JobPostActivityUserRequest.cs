using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.JobPostActivity
{
    public class JobPostActivityUserRequest
    {
        public int JobPostId { get; set; }
        public int CvId { get; set; }
        public int UserId { get; set; }
    }
}
