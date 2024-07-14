using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.User
{
    public class UserResultRequest
    {
        public int UserId { get; set; }
        public int ProgramId { get; set; }
        public List<UserResultDetailRequest> UserResultDetails { get; set; }
    }

    public class UserResultDetailRequest
    {
        public int KPIId { get; set; }
        public int Value { get; set; }
    }
}
