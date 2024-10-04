using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CurriculumVitae
    {
        public int Id { get; set; }
        public string Url { get; set; }
        //Navigation Property
        public int UserId { get; set; }
        public UserAccount UserAccount { get; set; }
        public List<JobPostActivity> JobPostActivitys { get; set; }
    }
}
