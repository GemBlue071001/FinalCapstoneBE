using Application.Response.JobType;
using Application.Response.SkillSet;
using Pgvector;

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
        public string? ImageURL { get; set; }
        public bool IsActive { get; set; }
        public Vector? Embedding { get; set; }
        //public UserResponse User { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteCompanyURL { get; set; }
        public JobTypeResponse JobType { get; set; }
        public List<string> JobLocationCities { get; set; }
        public List<string> JobLocationAddressDetail { get; set; }
        public List<string> SkillSets { get; set; }
        public List<SkillSetResponse> SkillSetObjects { get; set; }
    }
}
