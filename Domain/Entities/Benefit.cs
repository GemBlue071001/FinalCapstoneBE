using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Benefit : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //
        public List<SeekerBenefit> SeekerBenefits { get; set; }
        public List<JobPostBenefit> JobPostBenefits { get; set; }
    }
}
