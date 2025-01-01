using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.CompanyLocation
{
    public class CompanyLocationResponse
    {
        public int Id { get; set; }
        public string StressAddressDetail { get; set; } = string.Empty;


        // Navigation Property
        public string City { get; set; } = string.Empty;
        public int? LocationId { get; set; }
    }
}
