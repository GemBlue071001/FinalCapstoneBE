using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.JobLocation
{
    public class JobLocationRequest
    {
        public string StressAddressDetail { get; set; } = string.Empty;
        public int JobPostId { get; set; }
        public int LocationId { get; set; }
    }
}
