﻿using Application.Response.JobPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.Company
{
    public class CompanyResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string WebsiteURL { get; set; }
        public int EstablishedYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumberOfEmployees { get; set; }
        public List <JobPostResponse> JobPosts { get; set; }
    }
}