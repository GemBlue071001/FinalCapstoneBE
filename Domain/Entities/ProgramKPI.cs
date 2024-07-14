using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProgramKPI
    {
        public int Id { get; set; }
        public int KPIId { get; set; }
        public int TrainingProgramId  { get; set; }


        public TrainingProgram TrainingProgram { get; set; }
        public KPI KPI { get; set; }
        //public List<UserResult> UserResults { get; set; }
    }
}
