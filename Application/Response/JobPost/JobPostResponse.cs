using Application.Response.Company;
using Application.Response.JobLocation;
using Application.Response.JobType;
using Application.Response.User;
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
        //public UserResponse User { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteCompanyURL { get; set; }
        public JobTypeResponse JobType { get; set; }
        public JobLocationResponse JobLocation { get; set; }
    }
}
