using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SeekerSkillSet : Base
    {
        public int Id { get; set; }
        public string ProficiencyLevel { get; set; }

        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public int? UserId { get; set; }
        public SkillSet SkillSet { get; set; }
        public int? SkillSetId { get; set; }
    }
}
