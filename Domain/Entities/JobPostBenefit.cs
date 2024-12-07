using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobPostBenefit: Base
    {
        public int Id { get; set; }
        //
        public Benefit Benefit { get; set; }
        public int? BenefitId { get; set; }
        public JobPost JobPost { get; set; }
        public int? JobPostId { get; set; }
    }
}
