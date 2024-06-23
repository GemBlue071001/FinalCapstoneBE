using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserMeeting
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MeetingId { get; set; }

        public UserAccount User { get; set; }
        public Meeting Meeting { get; set; }
    }
}
