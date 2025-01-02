using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Location
{
    public class LocationRequest
    {
        public string City { get; set; } 
    }
    public class LocationUpdateRequest: LocationRequest
    {
        public int Id { get; set; }
    }
}
