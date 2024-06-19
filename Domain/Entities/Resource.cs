using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resource : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }

        //Navigation Property
        public List<TrainingProgramResource> TrainingProgramResources { get; set; }
    }
}
