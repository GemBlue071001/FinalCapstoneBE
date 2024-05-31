using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CampaignTrainingProgram
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int TrainingProgramId { get; set; }

       
        public TrainingProgram TrainingProgram { get; set; }
        public Campaign Campaign { get; set; }
    }
}
