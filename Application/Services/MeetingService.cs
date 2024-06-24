using Application.Interface;
using Application.Request.Meeting;
using Application.Response;
using Application.Response.MeetingResponse;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Application.Services
{
    public class MeetingService : IMeetingService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public MeetingService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> GetMeeting(int id)
        {
            var response = new ApiResponse();
            var meeting = await _unitOfWork.Meetings.GetAsync(x => x.Id == id, x => x.Include(x => x.UserMeetings).ThenInclude(u => u.User));   
            if(meeting == null) return response.SetNotFound();
            
            var meetingResponse = _mapper.Map<MeetingResponse>(meeting);   
            return response.SetOk(meetingResponse);
        }

        public async Task<ApiResponse> GetAllMeeting()
        {
            var response = new ApiResponse();
            var meetings = await _unitOfWork.Meetings.GetAllAsync(x => x.IsDeleted == false, x => x.Include(x => x.UserMeetings).ThenInclude(u => u.User));
            if (meetings == null) return response.SetNotFound();

            List<MeetingResponse> meetingResponses = [];

            foreach (var meeting in meetings)
            {
                var meetingResponse = _mapper.Map<MeetingResponse>(meeting);
                if(meetingResponse != null)
                {
                    meetingResponses.Add(meetingResponse);
                }
            }

            return response.SetOk(meetingResponses);
        }

        public async Task<ApiResponse> AddMeeting(MeetingRequest request)
        {
            var response = new ApiResponse();
            var meeting = _mapper.Map<Meeting>(request);
            if (request.UserIds.Any())
            {
                List<UserAccount> userAccounts = await _unitOfWork.UserAccounts.GetAllAsync(user => request.UserIds.Contains(user.Id));
                if (userAccounts.Any())
                {
                    List<UserMeeting> userMeetings = userAccounts.Select(x => new UserMeeting()
                    {
                        UserId = x.Id,
                    }).ToList();

                    meeting.UserMeetings.AddRange(userMeetings);
                }
            }
            await _unitOfWork.Meetings.AddAsync(meeting);
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("Created");
        }

        public async Task<ApiResponse> UpdateMeeting(MeetingUpdateRequest request)
        {
            var response = new ApiResponse();
            var meeting = await _unitOfWork.Meetings.GetAsync(x => x.Id == request.Id);
            if(meeting == null) return response.SetNotFound("Meeting ID: " + request.Id + "Not Found");

            meeting = _mapper.Map<Meeting>(request);
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("Updated");
        }

        public async Task<ApiResponse> AddUserToMeeting(int meetingId, int userId)
        {
            var response = new ApiResponse();
            var meeting = await _unitOfWork.Meetings.GetAsync(x => x.Id == meetingId, x => x.Include(x => x.UserMeetings));
            if (meeting == null)
            {
               return response.SetNotFound();
            }

            if (meeting.UserMeetings.Any(x => x.UserId == userId))
            {
                return response.SetBadRequest("User is already in meeting");
            }

            meeting.UserMeetings.Add(new UserMeeting() { UserId = userId });
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("User added to meeting");
        }

        public async Task<ApiResponse> RemoveUserFromMeeting(int meetingId, int userId)
        {
            var response = new ApiResponse();
            var userMeeting = await _unitOfWork.UserMeetings.GetAsync(x => x.MeetingId == meetingId && x.UserId == userId);
            if (userMeeting == null)
            {
                return response.SetNotFound("Meeting ID: " + meetingId + " Is Not Found");
            }
            await _unitOfWork.UserMeetings.RemoveByIdAsync(userMeeting.Id);
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("User removed from meeting");
        }

        public async Task<ApiResponse> RemoveMeeting(int id)
        {
            var response = new ApiResponse();

            var meeting = await _unitOfWork.Meetings.GetAsync(x => x.Id == id);
            if (meeting == null) 
            {
                return response.SetNotFound("Meeting ID: " + id + " Is Not Found");
            }
            meeting.IsDeleted = true;
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Meeting ID: "+ id +" Deleted");
        }

       
    }
}
