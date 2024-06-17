using Application.Interface;
using Application.Response;
using Application.Response.UserResponse;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> GetUserProfileAsync(int id)
        {
            ApiResponse response = new ApiResponse();

            var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == id);
            if (user == null)
                return response.SetNotFound("User not found");

            var userReponse = _mapper.Map<UserResponse>(user);

            return response.SetOk(userReponse);
        }

        public async Task<ApiResponse> GetUsersByUserName(string userName)
        {
            ApiResponse response = new ApiResponse();
            if (userName != null)
            {
                var users = await _unitOfWork.UserAccounts.GetAllAsync(u => u.UserName.Contains(userName));
                var userReponse = _mapper.Map<List<UserResponse>>(users);

                return response.SetOk(userReponse);

            }
            else
            {
                var users = await _unitOfWork.UserAccounts.GetAllAsync(null);
                var userReponse = _mapper.Map<List<UserResponse>>(users);

                return response.SetOk(userReponse);
            }


        }

    }
}
