using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAccount : Base
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Role Role { get; set; }

        //Navigation Property
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }
        public List<JobPost>? JobPosts { get; set; }
        public List<JobPostActivity>? JobPostActivitys { get; set; }
        //public List<SeekerProfile> SeekerProfiles { get; set; }
        public List<EducationDetail>? EducationDetails { get; set; }
        public List<ExperienceDetail>? ExperienceDetails { get; set; }
        public List<SeekerSkillSet>? SeekerSkillSets { get; set; }
        public List<CV>? CVs { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<FollowCompany>? FollowCompanys { get; set; }


    }

    public enum Role
    {
        JobSeeker,
        Employer,
        Admin,
    }
}
