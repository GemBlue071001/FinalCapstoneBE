using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Email
{
    public class EmailRequest
    {
        public string RecievedUser { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
