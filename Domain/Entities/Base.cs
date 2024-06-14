using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Base
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
