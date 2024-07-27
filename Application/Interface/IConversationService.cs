

using Application.Request.Conversation;
using Application.Response;

namespace Application.Interface
{
    public interface IConversationService
    {
        Task<ApiResponse> AddConversation(ConversationRequest request);
        Task<ApiResponse> GetAllConversation();
        Task<ApiResponse> AddUserToConversationAsync(ConversationUserRequest request);
        Task<ApiResponse> RemoveUserFromConversation(int conversationId, int userId);
        Task<ApiResponse> UpdateConversationAsync(ConversationUpdateRequest request);
    }
}
