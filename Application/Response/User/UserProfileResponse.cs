using Application.Request.SkillSet;
using Application.Response.Benefit;
using Application.Response.CV;
using Application.Response.SkillSet;
using Application.Response.UserAccountService;
using Domain.Entities;
namespace Application.Response.User

{
    public class UserProfileResponse
    {
        public int Id { get; set; }
        //public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int?  CompanyId { get; set; }
        public bool IsLookingForJob { get; set; }

        public string? CoverLetter { get; set; }
        public List<EducationDetailResponse> EducationDetails { get; set; } = new List<EducationDetailResponse>();
        public List<ExperienceDetailResponse> ExperienceDetails { get; set; } = new List<ExperienceDetailResponse>();
        public List<CVResponse> Cvs { get; set; } = new List<CVResponse>();
        public List<SkillSetResponse> SkillSets { get; set; } = new List<SkillSetResponse>();
        public List<BenefitResponse> Benefits { get; set; } = new List<BenefitResponse>();
        public List<UserAccountServiceResponse> UserAccountServices { get; set; }
    }
}
