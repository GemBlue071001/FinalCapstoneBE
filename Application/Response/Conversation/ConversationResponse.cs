
using Application.Response.Message;
using Application.Response.User;

namespace Application.Response.Conversation
{
    public class ConversationResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        //
        public List<MessageResponse> Messages { get; set; }
        public List<UserResponse> Users { get; set; }
    }
}
