

namespace Application.Request.Campaign
{
    public class UpdateCampainRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ScopeOfWork { get; set; }
        public string? Requirements { get; set; }
        public int Duration { get; set; }
        public string? ImagePath { get; set; }
        public string? Benefits { get; set; }
        public DateTime EstimateStartDate { get; set; }
        public DateTime EstimateEndDate { get; set; }
        public DateTime SubmissionDeadline { get; set; }
    }
}
