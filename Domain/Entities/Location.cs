using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string? District { get; set; }
        public string City { get; set; } = string.Empty;
        public string? PostCode { get; set; }

        public List<JobLocation> JobLocations { get; set; } = new List<JobLocation>();
        public List<CompanyLocation> CompanyLocations { get; set; } = new List<CompanyLocation>();
        public List<UserJobAlertCriteria> UserJobAlertCriterias { get; set; } = new List<UserJobAlertCriteria>();
    }
}
