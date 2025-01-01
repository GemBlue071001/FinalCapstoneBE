using Application.Request.CompanyLocation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Company
{
    public class CompanyRequest
    {
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string WebsiteURL { get; set; }
        public int EstablishedYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumberOfEmployees { get; set; }
        public int BusinessStreamId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Evidence { get; set; }
        public string? TaxCode { get; set; }
        //public List<int> JobPostsId { get; set; }
        public List<CompanyLocationRequest> CompanyLocations { get; set; }
    }

   
}
