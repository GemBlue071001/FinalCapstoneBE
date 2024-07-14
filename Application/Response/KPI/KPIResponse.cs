using Application.Response.TrainingProgram;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.KPI
{
    public class KPIResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Value { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }

        //
        public List<TrainingProgramResponse> TrainingPrograms { get; set; }
    }
}
