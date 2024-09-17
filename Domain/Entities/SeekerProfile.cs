using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SeekerProfile:Base
    {
        public int Id { get; set; }
        public string CvPath { get; set; }
        public int YearOfExperience { get; set; }
        public string Level { get; set; }
        public string LinkedInProfileURL { get; set; }
        public string GitHubProfileURL { get; set; }
        public string PortfolioURL { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public int UserId { get; set; }
        public List<ExperienceDetail> ExperienceDetails { get; set; }
        public List<EducationDetail> EducationDetails { get; set; }
        public List<SeekerSkillSet> SeekerSkillSets { get; set; }

    }
}
