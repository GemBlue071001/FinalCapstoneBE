using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.JobPost
{
    public class JobPostSkillSetRequest
    {
        public int JobPostId { get; set; }
        public int SkillSetId { get; set; }
        //public string SkillLevelRequired { get; set; }
    }
}
