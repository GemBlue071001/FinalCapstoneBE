using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.TrainingProgram
{
    public class TrainingUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string CourseObject { get; set; }
        public string OutputObject { get; set; }
    }
}
