using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Email
{
    public class CustomSendEmailRequest
    {
        public string Content { get; set; }
        public string CompanyName { get; set; }
        public string ReciveUser { get; set; }
    }
}
