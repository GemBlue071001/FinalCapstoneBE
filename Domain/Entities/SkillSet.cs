using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SkillSet:Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Shorthand { get; set; }
        public string? Description { get; set; }
        //public string SkillLevel { get; set; }
        //Navigation Property
        public List<SeekerSkillSet> SeekerSkillSets { get; set; }
        public List<JobSkillSet> JobSkillSets { get; set; }
        public List<UserJobAlertCriteria> UserJobAlertCriterias { get; set; } = new List<UserJobAlertCriteria>();

    }
}
