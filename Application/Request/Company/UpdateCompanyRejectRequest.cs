using Application.Request.CompanyLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Company
{
    public class UpdateCompanyRejectRequest
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string WebsiteURL { get; set; }
        public string? ImageUrl { get; set; }
        public int EstablishedYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Evidence { get; set; }
        public string TaxCode { get; set; }
        public List<CompanyLocationRequest> CompanyLocations { get; set; }
    }
}
