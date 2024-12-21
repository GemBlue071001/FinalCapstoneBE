using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Company
{
    public class UpdateCompanyStatusRequest
    {
        public int CompanyId { get; set; }
        public  CompanyStatus CompanyStatus { get; set; }
    }
}
