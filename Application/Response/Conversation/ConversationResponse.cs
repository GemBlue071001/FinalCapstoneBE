
using Application.Response.Message;
using Domain.Entities;

namespace Application.Response.Conversation
{
    public class ConversationResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        //
        List<MessageResponse> Messages { get; set; }
    }
}
