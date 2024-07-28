
namespace Domain.Entities
{
    public class Message : Base
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public int ConversationId { get; set; }
        public int UserId { get; set; }
        //
        public Conversation? Conversation { get; set; }
        public UserAccount? User { get; set; }
    }
}
