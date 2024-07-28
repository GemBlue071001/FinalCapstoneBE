using Application.Interface;
using Application.Request.Message;
using Application.Response;
using Application;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Application.Response.Message;
using Application.Response.KPI;
using DocumentFormat.OpenXml.Spreadsheet;
using Application.Request.Conversation;

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
    public async Task<ApiResponse> GetAllMessage()
    {
        var response = new ApiResponse();
        var messages = await _unitOfWork.Messages.GetAllAsync(null);

        var responseList = _mapper.Map<List<MessageResponse>>(messages);
        return response.SetOk(responseList);
    }
    public async Task<ApiResponse> RemoveMessageById(int id)
    {
        var response = new ApiResponse();
        var message = await _unitOfWork.Messages.GetAsync(x => id == x.Id);
        if (message == null)
        {
            return response.SetNotFound("Message ID: " + id + " Is Not Found");
        }
        _unitOfWork.Messages.RemoveByIdAsync(id);
        await _unitOfWork.SaveChangeAsync();

        return response.SetOk("Message ID: " + id + " Deleted");

    }
    


}
