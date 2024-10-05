using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EducationDetail : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstitutionName { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal GPA { get; set; }
        //Navigation Property
        public UserAccount? UserAccount { get; set; }
        public int? UserId { get; set; }

    }
}
