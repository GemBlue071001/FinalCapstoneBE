using Application.Interface;
using Application.Request.User;
using Application.Response;
using Application.Response.JobPostActivity;
using Application.Response.User;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private IClaimService _claimService;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }


        public async Task<ApiResponse> GetUserProfileAsync(int id)
        {
            ApiResponse response = new ApiResponse();

            var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == id);
            if (user == null)
                return response.SetNotFound("User not found");

            var userReponse = _mapper.Map<UserResponse>(user);

            return response.SetOk(user);
        }



        public async Task<ApiResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            ApiResponse response = new ApiResponse();
            var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == request.Id);
            if (user == null)
                return response.SetNotFound("User not found");
            if (!ValidateEmail(request.Email))
                return response.SetBadRequest("Invalid email format");
            if (!ValidatePhoneNum(request.PhoneNumber))
            {
                return response.SetBadRequest("Invalid phone format");

            }
            _mapper.Map(request, user);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(user);
        }


        public async Task<ApiResponse> GetUserJobPostActivity()
        {
            var claim = _claimService.GetUserClaim();

            var userJobPostActivities = await _unitOfWork.JobPostActivities.GetAllAsync(x => x.UserId == claim.Id, x => x.Include(x => x.JobPost));
            var jobPostActivitiesResponse = _mapper.Map<List<JobPostActivityResponse>>(userJobPostActivities);

            return new ApiResponse().SetOk(jobPostActivitiesResponse);
        }


        private bool ValidateEmail(string email)
        {
            var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(email);
        }

        private bool ValidatePhoneNum(string phoneNum)
        {
            var regex = new Regex(@"^-?\d+$");
            return regex.IsMatch(phoneNum);
        }
    }
}
