namespace Application.Request.JobPost
{
    public class SearchJobPostRequest
    {
        public string? CompanyName { get; set; }
        public string? SkillSet { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set;}
        public string? Location {  get; set; }
        public int? Experience { get; set; }
        public string? JobType { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 5;
    }
}
