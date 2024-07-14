using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserResult : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Total { get; set; }
        public int UserId { get; set; }
        public UserAccount User { get; set; }

        public int ProgramId { get; set; }
        public TrainingProgram Program { get; set; }
        public List<UserResultDetail> UserResultDetails { get; set; }
        //public int KPIId { get; set; }
    }
}
