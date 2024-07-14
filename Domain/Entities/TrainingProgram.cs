using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainingProgram : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string CourseObject { get; set; }
        public string OutputObject { get; set; }

        //Navigation Property
        public List<TrainingProgramResource> TrainingProgramResources { get; set; }
        public List<JobTrainingProgram> JobTrainingPrograms { get; set; }
        public List<ProgramKPI> ProgramKPI { get; set; }
        public List<Assessment> Assessments { get; set; }
        public List<UserResult> UserResults { get; set; }
    }
}
