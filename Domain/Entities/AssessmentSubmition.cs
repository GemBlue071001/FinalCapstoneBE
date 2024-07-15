using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AssessmentSubmition : Base
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime SubmitDate { get; set; } = DateTime.UtcNow;
        public string FilePath { get; set; } = string.Empty;


        //Navigation Property
        public int AssessmentId { get; set; }
        public Assessment Assessment { get; set; }

    }
}
