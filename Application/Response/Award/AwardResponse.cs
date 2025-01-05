namespace Application.Response.Award
{
    public class AwardResponse
    {
        public int Id { get; set; }
        public string AwardName { get; set; } = string.Empty;
        public string AwardOrganization { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
    }
}
