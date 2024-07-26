

using Application.Request.Conversation;
using Application.Response;

namespace Application.Interface
{
    public interface IConversationService
    {
        Task<ApiResponse> AddConversation(ConversationRequest request);
        Task<ApiResponse> GetAllConversation();
    }
}
