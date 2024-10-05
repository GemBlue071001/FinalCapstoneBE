using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExperienceDetail:Base
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Responsibilities { get; set; }
        public string Achievements { get; set; }
        //Navigation Property
        //public SeekerProfile SeekerProfile { get; set; }
        //public int SeekerProfileId { get; set; }
        public UserAccount? UserAccount { get; set; }
        public int? UserId { get; set; }

    }
}
