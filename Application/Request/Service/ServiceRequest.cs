using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Service
{
    public class ServiceRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPost { get; set; }
        public decimal Price { get; set; }
    }
}
