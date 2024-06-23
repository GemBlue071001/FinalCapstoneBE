using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Resource
{
    public class ResourceRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public List<int> TrainingProgramIds { get; set; }
    }
}
