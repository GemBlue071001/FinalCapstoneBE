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

        public int? TrainingProgramId { get; set; }

        public TrainingProgram? TrainingProgram { get; set; }
    }

    public enum Role
    {
        Intern,
        Mentor,
        InternshipCoordinators,
        HRManager,
        Admin
    }
}
