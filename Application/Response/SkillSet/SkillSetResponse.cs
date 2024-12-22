using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.SkillSet
{
    public class SkillSetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shorthand { get; set; }
        public string Description { get; set; }
        public string ProficiencyLevel { get; set; } = string.Empty;
    }
}
