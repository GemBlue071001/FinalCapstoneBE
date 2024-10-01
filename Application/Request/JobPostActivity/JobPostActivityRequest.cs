using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.JobPostActivity
{
    public class JobPostActivityRequest
    {
        public int UserId { get; set; }
        public List<int> JobPostIds { get; set; }
        
    }
}
