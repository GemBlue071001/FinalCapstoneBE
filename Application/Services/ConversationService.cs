using Application.Interface;
using Application.Request.Conversation;
using Application.Response.Conversation;
using Application.Response;
using Application;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;

public class ConversationService : IConversationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ConversationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ApiResponse> AddConversation(ConversationRequest request)
    {
        var response = new ApiResponse();


        var conversation = _mapper.Map<Conversation>(request);
        conversation.CreatedDate = DateTime.UtcNow;

        await _unitOfWork.Conversations.AddAsync(conversation);
        await _unitOfWork.SaveChangeAsync();

        return response.SetOk("Create Success !!");
    }
    public async Task<ApiResponse> GetAllConversation()
    {
        var response = new ApiResponse();
        var conversations = await _unitOfWork.Conversations.GetAllAsync(null, x => x.Include(x => x.Messages)
                                                                                         .ThenInclude(x => x.User)
                                                                                    .Include(x => x.UserConversations)
                                                                                         .ThenInclude(x => x.User));
        var responseList = _mapper.Map<List<ConversationResponse>>(conversations);

        return response.SetOk(responseList);
    }
    public async Task<ApiResponse> AddUserToConversationAsync(ConversationUserRequest request)
    {
        var response = new ApiResponse();
        var conversationUser = await _unitOfWork.ConversationsUsers.GetAsync(x => x.UserId == request.UserId &&
                                                                    x.ConversationId == request.ConversationId);
        if (conversationUser != null)
            return response.SetBadRequest("User already exist in this Conversation !!");
        await _unitOfWork.ConversationsUsers.AddAsync(new UserConversation
        {
            UserId = request.UserId,
            ConversationId = request.ConversationId,
        });
        await _unitOfWork.SaveChangeAsync();

        return response.SetOk("Add User To Coversation Success !!");
    }
    public async Task<ApiResponse> UpdateConversationAsync(ConversationUpdateRequest request)
    {
        var response = new ApiResponse();
        var conversation = await _unitOfWork.Conversations.GetAsync(x => x.Id == request.Id);
        if (conversation == null)
        {
            return response.SetNotFound($"Conversation {request.Id} Not Found");
        }
        _mapper.Map(request, conversation);
        await _unitOfWork.SaveChangeAsync();
        return response.SetOk($"Update Conversation {request.Id} Success");
    }

    public async Task<ApiResponse> RemoveUserFromConversation(int conversationId, int userId)
    {
        var response = new ApiResponse();
        var conversationUser = await _unitOfWork.ConversationsUsers.GetAsync(x => x.UserId == userId &&
                                                                    x.ConversationId == conversationId);
        if (conversationUser == null)
        {
            return response.SetNotFound($"Not Found Coversation{conversationId}");
        }
        await _unitOfWork.ConversationsUsers.RemoveByIdAsync(conversationUser.Id);
        await _unitOfWork.SaveChangeAsync();
        return response.SetOk("User removed from Conversation");
    }
}
