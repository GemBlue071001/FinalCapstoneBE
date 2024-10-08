﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.SeekerProfile
{
    public class SeekerProfileResponse
    {
        public int Id { get; set; }
        public string CvPath { get; set; }
        public int YearOfExperience { get; set; }
        public string Level { get; set; }
        public string LinkedInProfileURL { get; set; }
        public string GitHubProfileURL { get; set; }
        public string PortfolioURL { get; set; }
        public string Summary { get; set; }
    }
}
