using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.UserJobAlertCriteria
{
    public class UserJobAlertCriteriaRequest
    {
        public string JobTile { get; set; } = string.Empty;
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public int? LocationId { get; set; }
        public int? SkillSetId { get; set; }
        public int? JobTypeId { get; set; }
        public int UserId { get; set; }
    }
}
