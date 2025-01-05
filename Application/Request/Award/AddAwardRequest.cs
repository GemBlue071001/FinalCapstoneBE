namespace Application.Request.Award
{
    public class AddAwardRequest
    {
        public string AwardName { get; set; } = string.Empty;
        public string AwardOrganization { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
    }
}
