
namespace Domain.Entities
{
    public class Conversation: Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        //
        public Message? Message { get; set; }
        public UserConversation? UserConversation { get; set; }
        public List<Message> Messages { get; set; }
        public List<UserConversation> UserConversations { get; set; }

    }
}
