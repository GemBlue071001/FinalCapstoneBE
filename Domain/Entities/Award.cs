namespace Domain.Entities
{
    public class Award
    {
        public int Id { get; set; }
        public string AwardName { get; set; } = string.Empty;
        public string AwardOrganization { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }

        //Navigation Property
        public UserAccount? UserAccount { get; set; }
        public int? UserId { get; set; }
    }
}
