using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.TrainingProgram
{
    public class TrainingProgramRequest
    {
        public string Name { get; set; }
        public string ScopeOfWork { get; set; }
        public string Requirements { get; set; }
        public string Benefits { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int TotalMember { get; set; }
    }
}
