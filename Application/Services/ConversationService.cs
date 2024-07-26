using Application.Interface;
using Application.Request.Conversation;
using Application.Response.Conversation;
using Application.Response;
using Application;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

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


        return response;
    }


    public async Task<ApiResponse> GetAllConversation()
    {
        var response = new ApiResponse();
        var conversations = await _unitOfWork.Conversations.GetAllAsync(null, x => x.Include(x => x.Messages)
                                                                        .ThenInclude(x => x.User));
        var responseList = _mapper.Map<List<ConversationResponse>>(conversations);

        return response.SetOk(responseList);
    }
}
