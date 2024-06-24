namespace Application.Request.Job
{
    public class UpdateJobRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ScopeOfWork { get; set; }
        public string? Requirements { get; set; }
        public string? Benefits { get; set; }
        public DateTime? StartDate { get; set; }
        public int Duration { get; set; }
        public int TotalMember { get; set; }
        public string? ImagePath { get; set; }
    }
}
