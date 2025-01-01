using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.CompanyLocation
{
    public class CompanyLocationRequest
    {
        public int LocationId { get; set; }
        public string StressAddressDetail { get; set; } = string.Empty;
    }
}
