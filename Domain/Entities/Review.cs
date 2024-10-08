using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string ReviewContent { get; set; }
        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public int? UserId { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
    }
}
