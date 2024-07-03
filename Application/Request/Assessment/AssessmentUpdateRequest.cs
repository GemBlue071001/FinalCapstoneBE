using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Assessment
{
    public class AssessmentUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public int EstimateTime { get; set; }
        public DateTime EndDate { get; set; }
        public int ActualTime { get; set; }
    }
}
