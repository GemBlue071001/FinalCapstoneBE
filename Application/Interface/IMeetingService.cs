using Application.Request.Meeting;
using Application.Response;

namespace Application.Interface
{
    public interface IMeetingService
    {
        Task<ApiResponse> GetMeeting(int id);
        Task<ApiResponse> GetAllMeeting();
        Task<ApiResponse> AddMeeting(MeetingRequest meeting);
        Task<ApiResponse> UpdateMeeting(MeetingUpdateRequest meeting);
        Task<ApiResponse> RemoveMeeting(int id);
        Task<ApiResponse> AddUserToMeeting(int meetingId, int userId);
        Task<ApiResponse> RemoveUserFromMeeting(int meetingId, int userId);


    }
}
