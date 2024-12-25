using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAccountService : Base
    {
        public int Id { get; set; }
        //
        public UserAccount UserAccount { get; set; }
        public int UserId { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }
    }
}
