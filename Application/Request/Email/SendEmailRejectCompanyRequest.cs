using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Email
{
    public class SendEmailRejectCompanyRequest
    {
        public string CompanyEmail { get; set; }
        public string EmailContent { get; set; }
        public string CompanyName { get; set; }
    }
}
