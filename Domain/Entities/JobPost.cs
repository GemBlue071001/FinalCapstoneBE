using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobPost: Base
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal Salary { get; set; }
        //public string Currency { get; set; }
        //public string EmploymentType { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ExperienceRequired { get; set; }
        public string? QualificationRequired { get; set; }
        public string? ImageURL { get; set; }

        public int SkillLevelRequired { get; set; }
        public string? Benefits { get; set; }
        public bool IsActive { get; set; }

        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public JobType  JobType { get; set; }
        public Company Company { get; set; }
        public JobLocation JobLocation { get; set; }
        public int UserId { get; set; }
        public int JobTypeId { get; set; }
        public int CompanyId { get; set; }
        public int JobLocationId { get; set; }
        public List<JobSkillSet> JobSkillSets { get; set; }
        public List<JobPostActivity> JobPostActivitys { get; set; }

    }
}
