using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.UserJobAlertCriteria
{
    public class UserJobAlertCriteriaResponse
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public int? LocationId { get; set; }
        public int? SkillSetId { get; set; }
        public int? JobTypeId { get; set; }
        public int UserId { get; set; }
    }
}
