using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.User
{
    public class FindTalentRequest
    {
        public string? Keyword { get; set; }
        //public string? SkillSet { get; set; }
        public string? Degree { get; set; }
        //public string[]? SkillSets { get; set; }
        public List<SkillSetFilter>? SkillSetFilters { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 5;

    }
    public class SkillSetFilter
    {
        public string? SkillSet { get; set; }
        public string? ProficiencyLevel { get; set; }
    }
}
