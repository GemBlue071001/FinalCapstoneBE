using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobSkillSet:Base
    {
        public int Id{ get; set; }
        //Navigation Property
        public SkillSet SkillSet { get; set; }
        public int SkillSetId { get; set; }
        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}
