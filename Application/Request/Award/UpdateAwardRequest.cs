namespace Application.Request.Award
{
    public class UpdateAwardRequest
    {
        public int Id { get; set; }
        public string AwardName { get; set; } = string.Empty;
        public string AwardOrganization { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
    }
}
