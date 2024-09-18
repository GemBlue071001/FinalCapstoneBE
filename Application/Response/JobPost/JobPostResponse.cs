using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.JobPost
{
    public class JobPostResponse
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal Salary { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ExperienceRequired { get; set; }
        public string QualificationRequired { get; set; }
        public string Benefits { get; set; }
        public bool IsActive { get; set; }
    }
}
