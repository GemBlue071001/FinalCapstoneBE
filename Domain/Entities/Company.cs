using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company: Base
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
        public string? Evidence { get; set; }
        public string? TaxCode { get; set; }
        public CompanyStatus? CompanyStatus { get; set; }

        //Navigation Property
        public List<JobPost> JobPosts { get; set; }
        public BusinessStream BusinessStream { get; set; }
        public int? BusinessStreamId { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<UserAccount>? UserAccounts { get; set; }
        public List<FollowCompany> FollowCompanys { get; set; }
        public List<EmailVerification>? EmailVerifications { get; set; }
    }
    public enum CompanyStatus
    {
        [Display(Name = "Pending")]
        Pending = 0,
        [Display(Name = "Reject")]
        Reject = 1,
        [Display(Name = "Approve")]
        Approve = 2
    }
}
