using Application.Response.Job;
using Application.Response.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.TrainingProgram
{
    public class TrainingProgramResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string CourseObject { get; set; }
        public string OutputObject { get; set; }
        //public List<JobTrainingProgramResponse> Jobs { get; set; }
        public List<TrainingProgramResourceResponse> TrainingProgramResources { get; set; }
    }
}
