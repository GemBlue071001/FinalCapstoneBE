using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.AssessmentSubmition
{
    public class SubmitionRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime SubmitDate { get; set; } = DateTime.UtcNow;
        public string FilePath { get; set; } = string.Empty;
        public int AssessmentId { get; set; }
    }
}
