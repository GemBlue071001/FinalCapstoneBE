using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.User
{
    public class SeekerSkillSetRequest
    {
        public int UserId { get; set; }
        public int SkillSetId { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
