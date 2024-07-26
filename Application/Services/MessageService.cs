using Application.Interface;
using Application.Request.Message;
using Application.Response;
using Application;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class MessageService : IMessageService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MessageService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    public async Task<ApiResponse> AddMessages(MessageRequest request)
    {
        var response = new ApiResponse();


        var message = _mapper.Map<Message>(request);

        var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == request.UserId);
        var conversation = await _unitOfWork.Conversations.GetAsync(x => x.Id == request.ConversationId);

        if (user == null)
        {
            return response.SetBadRequest($"User {request.UserId} not Found");
        }
        if (conversation == null)
        {
            return response.SetBadRequest($"Conversation {request.ConversationId} not Found");
        }

        await _unitOfWork.Messages.AddAsync(message);
        await _unitOfWork.SaveChangeAsync();

        return response.SetOk("Create Success !!");

    }
}
