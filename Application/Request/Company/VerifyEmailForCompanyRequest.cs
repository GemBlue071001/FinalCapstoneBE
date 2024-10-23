using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Company
{
    public class VerifyEmailForCompanyRequest
    {
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public string VerificationCode { get; set; }
    }
}
