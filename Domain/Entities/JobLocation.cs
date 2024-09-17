using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobLocation: Base
    {
        public int Id { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        //Navigation Property
        public List<JobPost> JobPosts { get; set; }
    }
}
