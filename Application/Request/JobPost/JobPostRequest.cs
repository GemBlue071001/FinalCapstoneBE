using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.JobPost
{
    public class JobPostRequest
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal Salary { get; set; }
        //public DateTime PostingDate { get; set; } = DateTime.SpecifyKind(new DateTime(), DateTimeKind.Utc);
        //public DateTime ExpiryDate { get; set; }
        public int ExperienceRequired { get; set; }
        public string QualificationRequired { get; set; }
        public string Benefits { get; set; }
        public int JobTypeId { get; set; }
        public int CompanyId { get; set; }
        public int JobLocationId { get; set; }
        public int UserId { get; set; }



    }
}
