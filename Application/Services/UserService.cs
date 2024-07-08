﻿using Application.Interface;
using Application.Request.User;
using Application.Response;
using Application.Response.User;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //if (user == null)
            //    return response.SetNotFound("User not found");

            //var userReponse = _mapper.Map<UserResponse>(user);

            return response.SetOk(user);
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

        public async Task<ApiResponse> GetInternInCampaginJobAsync(int campaginId, int jobId)
        {
            ApiResponse response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(x => x.CampaignId == campaginId && x.JobId == jobId);
            if (campaignJob != null)
            {
                var interns = await _unitOfWork.UserAccounts.GetAllAsync(x => x.CampaignJobId == campaignJob.Id);
                var listInternResponse = _mapper.Map<List<UserResponse>>(interns);

                return response.SetOk(listInternResponse);
            }
            return response.SetBadRequest("campaign job is not found! ");
        }

        public async Task<ApiResponse> AddUserToCampaginJobAsync(UserCampaignJobRequest request)
        {
            ApiResponse response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(x => x.CampaignId == request.CampaginId && x.JobId == request.JobId);
            if (campaignJob != null)
            {
                var intern = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == request.UserId);
                intern.CampaignJobId = campaignJob.Id;
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Added user to campaign job!");
            }
            return response.SetBadRequest("campaign job is not found! ");
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
