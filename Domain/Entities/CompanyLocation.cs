using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompanyLocation
    {
        public int Id { get; set; }
        public string StressAddressDetail { get; set; } = string.Empty;


        // Navigation Property
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }
        public Location? Location { get; set; }
        public int? LocationId { get; set; }
    }
}
