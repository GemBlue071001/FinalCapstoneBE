using Application.Interface;
using Application.Request.User;
using Application.Response;
using Application.Response.JobPostActivity;
using Application.Response.User;
using AutoMapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Domain.Entities;
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
            var claim = _claimService.GetUserClaim();
            var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == id, x => x.Include(x => x.EducationDetails!)
                                                                                     .Include(x => x.ExperienceDetails!)
                                                                                     .Include(x => x.SeekerSkillSets!)
                                                                                        .ThenInclude(x => x.SkillSet));
            if (user == null)
                return response.SetNotFound("User not found");

            var userReponse = _mapper.Map<UserProfileResponse>(user);

            return response.SetOk(userReponse);
        }



        public async Task<ApiResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            try
            {
                ApiResponse response = new ApiResponse();
                var claim = _claimService.GetUserClaim();
                var user = await _unitOfWork.UserAccounts.GetAsync(u => u.Id == claim.Id);
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

                return response.SetOk("Update Success");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> GetUserJobPostActivity()
        {
            var claim = _claimService.GetUserClaim();

            var userJobPostActivities = await _unitOfWork.JobPostActivities.GetAllAsync(x => x.UserId == claim.Id, x => x.Include(x => x.JobPost));
            var jobPostActivitiesResponse = _mapper.Map<List<JobPostActivityResponse>>(userJobPostActivities);

            return new ApiResponse().SetOk(jobPostActivitiesResponse);
        }

        public async Task<ApiResponse> AddEmployerToCompany(AddEmployerToCompanyRequest request)
        {
            var claim = _claimService.GetUserClaim();
            try
            {
                if (claim.Role != Role.Employer)
                {
                    return new ApiResponse().SetBadRequest("User be employer");
                }
                var company = await _unitOfWork.Companys.GetAsync(x => x.Id == request.CompanyId);
                if (company == null)
                {
                    return new ApiResponse().SetBadRequest("Company not exist");
                }
                var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == claim.Id);
                user.CompanyId = company.Id;
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk("Add success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }


        public async Task<ApiResponse> AddSkillSetToUser(SeekerSkillSetRequest request)
        {
            try
            {
                var user = await _unitOfWork.UserAccounts.GetAsync(x => x.Id == request.UserId);
                if (user == null)
                {
                    return new ApiResponse().SetBadRequest("User Not Found");
                }

                var skillSet = await _unitOfWork.SkillSets.GetAsync(x => x.Id == request.SkillSetId);
                if (skillSet == null)
                {
                    return new ApiResponse().SetBadRequest("Skill Set Not Found !");
                }

                var seekerSkillSet = _mapper.Map<SeekerSkillSet>(request);

                await _unitOfWork.SeekerSkillSets.AddAsync(seekerSkillSet);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk(seekerSkillSet.Id);
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
        }

        public async Task<ApiResponse> RemoveSkillSetToUser(SeekerSkillSetRequest request)
        {
            try
            {
                var userSkillSet = await _unitOfWork.SeekerSkillSets.GetAsync(x => x.UserId == request.UserId && x.SkillSetId == request.SkillSetId);
                if (userSkillSet == null)
                {
                    return new ApiResponse().SetBadRequest("User Skill Set Not Found !");
                }

                await _unitOfWork.SeekerSkillSets.RemoveByIdAsync(userSkillSet.Id);
                await _unitOfWork.SaveChangeAsync();

                return new ApiResponse().SetOk("Remove success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest($"{ex.Message} - InnerException:  {ex.InnerException?.Message}");
            }
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
        public async Task<ApiResponse> GetAllJobSeekerRoleAsync()
        {
            ApiResponse response = new ApiResponse();
            var users = await _unitOfWork.UserAccounts.GetAllAsync(u => u.Role == Role.JobSeeker, x => x.Include(x => x.EducationDetails!)
                                                                                     .Include(x => x.ExperienceDetails!)
                                                                                     .Include(x => x.SeekerSkillSets!)
                                                                                        .ThenInclude(x => x.SkillSet));

            var userReponse = _mapper.Map<List<UserProfileResponse>>(users);

            return response.SetOk(userReponse);
        }
    }
}
