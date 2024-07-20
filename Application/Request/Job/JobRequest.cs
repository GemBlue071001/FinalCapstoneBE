using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Job
{
    public class JobRequest
    {
        public string Name { get; set; }
        public string ScopeOfWork { get; set; }
        public string Requirements { get; set; }
        public string Benefits { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int TotalMember { get; set; }
        public string? ImagePath { get; set; }
        public string? Location { get; set; }

    }
}
