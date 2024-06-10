using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string CourseObject { get; set; }
        public string OutputObject { get; set; }

        public List<JobTrainingProgram> JobTrainingPrograms { get; set; }
    }
}
