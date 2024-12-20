﻿using Application.CustomExceptions;
using Application.Interface;
using Application.Request.EducationDetail;
using Application.Response;
using AutoMapper;
using Domain.Entities;
using System.Net;

namespace Application.Services
{
    public class EducationDetailsService : IEducationDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IClaimService _claimService;

        public EducationDetailsService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task ResetEducationDetaildSequenceAsync()
        {
            var x = await _unitOfWork.EducationDetails.CountAsync();
            if (x <= 0)
                return;
            // Get the sequence name for the EducationDetail.Id column
            string sequenceSql = "SELECT pg_get_serial_sequence('\"EducationDetails\"', 'Id')";
            string sequenceName = await _unitOfWork.ExecuteScalarAsync<string>(sequenceSql);

            if (!string.IsNullOrEmpty(sequenceName))
            {
                // Get the current maximum ID in the EducationDetails table
                string maxIdSql = "SELECT COALESCE(MAX(\"Id\"), 0) FROM \"EducationDetails\"";
                int maxId = await _unitOfWork.ExecuteScalarAsync<int>(maxIdSql);

                // Update the sequence to start from the max ID
                string resetSequenceSql = $"SELECT setval('{sequenceName}', {maxId})";
                await _unitOfWork.ExecuteRawSqlAsync(resetSequenceSql);
            }
        }
        public async Task<ApiResponse> AddNewEducationDetailAsync(EducationDetailRequest request)
        {
            try
            {
                await ResetEducationDetaildSequenceAsync();
                var claim = _claimService.GetUserClaim();
                var educationDetail = _mapper.Map<EducationDetail>(request);
                educationDetail.UserId = claim.Id;

                await _unitOfWork.EducationDetails.AddAsync(educationDetail);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetEducationDetailListAsync()
        {
            var claim = _claimService.GetUserClaim();
            var educations = await _unitOfWork.EducationDetails.GetAllAsync(x => x.UserId == claim.Id);
            var responseList = _mapper.Map<List<EducationDetailResponse>>(educations);

            return new ApiResponse().SetOk(responseList);
        }

        public async Task<ApiResponse> UpdateEducationDetailAsync(int userId, UpdateEducationDetailRequest request)
        {
            var educationDetail = await _unitOfWork.EducationDetails.GetAsync(education => education.Id == request.Id);
            if (educationDetail == null)
            {
                throw new NotFoundException($"Education Detail ID: {request.Id} not found.");
            }

            if(educationDetail.UserId != userId)
            {
                throw new NotMatchException($"UserId from request: {educationDetail.UserId} not match with ${userId}");
            }

            //educationDetail.Name = request.Name;
            educationDetail.InstitutionName = request.InstitutionName;
            educationDetail.Degree = request.Degree;
            educationDetail.FieldOfStudy = request.FieldOfStudy;
            educationDetail.StartDate = request.StartDate;
            educationDetail.EndDate = request.EndDate;
            educationDetail.GPA = request.GPA;

            await _unitOfWork.SaveChangeAsync();

            return new ApiResponse().SetApiResponse(HttpStatusCode.NoContent, true, string.Empty, educationDetail.Id.ToString());
        }
        public async Task<ApiResponse> DeleteEducationDetailByIdAsync(int id)
        {
            var response = new ApiResponse();
            try
            {
                var educationDetail = await _unitOfWork.EducationDetails.GetAsync(x => x.Id == id);
                if (educationDetail == null)
                {
                    return response.SetNotFound("Can not found Education Detail id: " + id);
                }
                await _unitOfWork.EducationDetails.RemoveByIdAsync(educationDetail.Id);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk(educationDetail);
            }
            catch (Exception ex)
            {
                return response.SetBadRequest(ex.Message);
            }
        }
    }
}
