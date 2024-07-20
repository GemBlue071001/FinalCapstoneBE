using Application.Interface;
using Application.Request.User;
using Application.Response;
using Application.Response.User;
using AutoMapper;
using DocumentFormat.OpenXml.Spreadsheet;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
            //if (user == null)
            //    return response.SetNotFound("User not found");

            //var userReponse = _mapper.Map<UserResponse>(user);

            return response.SetOk(user);
        }

        public async Task<ApiResponse> GetUsers(string userName)
        {
            ApiResponse response = new ApiResponse();
            var userClaim = _claimService.GetUserClaim();
            var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == userClaim.Id);

            List<UserAccount> users;
            if (userClaim.Role == Role.InternshipCoordinators)
            {
                users = userName != null
                    ? await _unitOfWork.UserAccounts.GetAllAsync(u => u.UserName.Contains(userName))
                    : await _unitOfWork.UserAccounts.GetAllAsync(null);
            }
            else
            {
                if (user.CampaignJobId != null)
                {
                    users = userName != null
                       ? await _unitOfWork.UserAccounts.GetAllAsync(u => u.UserName.Contains(userName) && u.CampaignJobId == user.CampaignJobId)
                       : await _unitOfWork.UserAccounts.GetAllAsync(u => u.CampaignJobId == user.CampaignJobId);
                }
                else
                {
                    users = new List<UserAccount>();
                }
            }


            var userResponse = _mapper.Map<List<UserResponse>>(users);
            return response.SetOk(userResponse);
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

        public async Task<ApiResponse> EveluateInternKPI(UserResultRequest request)
        {
            var response = new ApiResponse();

            var userResultTemp = await _unitOfWork.UserResults.GetAsync(x => x.UserId == request.UserId && x.ProgramId == request.ProgramId,
                                                                         include: x => x.Include(x => x.UserResultDetails));

            if (userResultTemp != null)
            {
                var program = await _unitOfWork.TrainingPrograms.GetAsync(x => x.Id == request.ProgramId,
                                                                    include: x => x.Include(x => x.ProgramKPI).ThenInclude(x => x.KPI));
                if (program == null)
                {
                    return response.SetBadRequest("Training program not found");
                }

                float total = 0f;
                List<UserResultDetail> userResultDetails = new List<UserResultDetail>();

                foreach (var detailDto in request.UserResultDetails)
                {
                    var kpi = program.ProgramKPI.FirstOrDefault(tpk => tpk.KPIId == detailDto.KPIId)?.KPI;
                    if (kpi == null)
                    {
                        return response.SetBadRequest($"KPI with Id {detailDto.KPIId} not found in the program");
                    }
                    UserResultDetail detail = new UserResultDetail
                    {
                        Value = detailDto.Value,
                        Weight = kpi.Weight,
                        Name = kpi.Name
                    };
                    userResultDetails.Add(detail);
                    total += (detail.Weight / 100.0f) * detail.Value;
                }

                //userResultTemp.UserResultDetails = userResultDetails;
                _mapper.Map(userResultDetails, userResultTemp.UserResultDetails);
                userResultTemp.Total = total;
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Completed");

            }

            #region add

            else
            {
                var program = await _unitOfWork.TrainingPrograms.GetAsync(x => x.Id == request.ProgramId,
                                                                    include: x => x.Include(x => x.ProgramKPI).ThenInclude(x => x.KPI));
                if (program == null)
                {
                    return response.SetBadRequest("Training program not found");
                }

                float total = 0f;
                List<UserResultDetail> userResultDetails = new List<UserResultDetail>();

                foreach (var detailDto in request.UserResultDetails)
                {
                    var kpi = program.ProgramKPI.FirstOrDefault(tpk => tpk.KPIId == detailDto.KPIId)?.KPI;
                    if (kpi == null)
                    {
                        return response.SetBadRequest($"KPI with Id {detailDto.KPIId} not found in the program");
                    }
                    UserResultDetail detail = new UserResultDetail
                    {
                        Value = detailDto.Value,
                        Weight = kpi.Weight,
                        Name = kpi.Name
                    };
                    userResultDetails.Add(detail);
                    total += (detail.Weight / 100.0f) * detail.Value;
                }

                var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == request.UserId);

                UserResult userResult = new UserResult
                {
                    UserId = request.UserId,
                    ProgramId = request.ProgramId,
                    Total = total,
                    UserResultDetails = userResultDetails,
                    Name = user.UserName,
                };

                await _unitOfWork.UserResults.AddAsync(userResult);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk("Completed");
            }
            #endregion

        }

        public async Task<ApiResponse> GetInternResult(int programId, int userId)
        {
            var response = new ApiResponse();
            var internResults = await _unitOfWork.UserResults.GetAsync(x => x.ProgramId == programId && x.UserId == userId,
                                                                        include: x => x.Include(x => x.UserResultDetails));
            var respnseInternResults = _mapper.Map<UserResultResponse>(internResults);

            return response.SetOk(respnseInternResults);
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
