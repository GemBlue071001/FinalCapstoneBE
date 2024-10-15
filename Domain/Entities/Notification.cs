namespace Domain.Entities
{
    public class Notification : Base
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReceiverId { get; set; }
        public bool IsRead { get; set; }
        public int? JobPostActivityId { get; set; }

        public JobPostActivity? JobPostActivity { get; set; }
        public UserAccount UserAccount { get; set; }
    }
}
