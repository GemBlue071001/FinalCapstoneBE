using Application.Response.CV;
namespace Application.Response.User

{
    public class UserProfileResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public List<EducationDetailResponse> EducationDetails { get; set; } = new List<EducationDetailResponse>();
        public List<ExperienceDetailResponse> ExperienceDetails { get; set; } = new List<ExperienceDetailResponse>();
        public List<CVResponse> Cvs { get; set; } = new List<CVResponse>();
        public List<string> SkillSets { get; set; } = new List<string>();
    }
}
