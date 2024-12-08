namespace Application.Request.JobPost
{
    public class JobPostRequest
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal Salary { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ExperienceRequired { get; set; }
        public string QualificationRequired { get; set; }
        public string Benefits { get; set; }
        //public int SkillLevelRequired { get; set; }
        public int JobTypeId { get; set; }
        public int CompanyId { get; set; }
        public string? ImageURL { get; set; }
        //public int JobLocationId { get; set; }
        public int UserId { get; set; }
        public List<int?> SkillSetIds { get; set; }
        public List<int?> BenefitIds { get; set; }

    }
}
