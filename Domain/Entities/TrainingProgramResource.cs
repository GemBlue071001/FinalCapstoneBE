using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainingProgramResource
    {
        public int Id { get; set; }
        public int? ResourceId { get; set; }
        public int? TrainingProgramId { get; set; }

        //Navigation Property
        public TrainingProgram? TrainingProgram { get; set; }
        public Resource? Resource { get; set; }
    }
}
