namespace Application.Request.JobPost
{
    public class SearchJobPostRequest
    {
        public string? CompanyName { get; set; }
        public string? Keyword { get; set; }
        public string[]? CompanyNames { get; set; } // New array property
        public string? JobTitle { get; set; }
        public string[]? JobTitles { get; set; } // New array property
        public string? SkillSet { get; set; }
        public string[]? SkillSets { get; set; } // New array property
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public string? Location { get; set; }
        public string[]? Locations { get; set; } // New array property
        public string? City { get; set; }
        public string[]? Cities { get; set; } // New array property
        public int? Experience { get; set; }
        public string? JobType { get; set; }
        public string[]? JobTypes { get; set; } // New array property
        public string? Benefit { get; set; }
        public string[]? Benefits { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 5;
    }

}
