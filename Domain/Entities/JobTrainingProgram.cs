using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobTrainingProgram
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public int? TrainingProgramId { get; set; }

        public Job? Job { get; set; }
        public TrainingProgram? TrainingProgram { get; set; }
    }
}
