using Application.Interface;
using Application.Request.Candidate;
using Application.Response;
using Application.Response.Candidate;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CandidateService : ICandidateService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private IClaimService _claimService;

        public CandidateService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }

        public async Task<ApiResponse> AddCadidate(CandidateRequest request)
        {
            var userClaim = _claimService.GetUserClaim();

            var response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(p => p.CampaignId == request.CampaignId &&
                                                                          p.JobId == request.JobId);

            if (campaignJob == null)
                return response.SetBadRequest("Campaign Job not found !!");

            var candidate = _mapper.Map<Candidate>(request);
            candidate.CampaignJobId = campaignJob.Id;
            candidate.UserId = userClaim.Id;

            await _unitOfWork.Candidates.AddAsync(candidate);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetUserAplication()
        {
            var userClaim = _claimService.GetUserClaim();
            var response = new ApiResponse();

            var candidates = await _unitOfWork.Candidates.GetAllAsync(x => x.UserId == userClaim.Id,
                                                                    include: x => x.Include(x => x.CampaignJob)
                                                                                        .ThenInclude(x => x.Campaign)
                                                                                   .Include(x => x.CampaignJob).ThenInclude(x => x.Job));
            var responseList = _mapper.Map<List<CandidateResponse>>(candidates);
            return response.SetOk(responseList);

        }

        public async Task<ApiResponse> GetProgramCadidate(int campaignId, int jobId)
        {
            var response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(p => p.CampaignId == campaignId &&
                                                                          p.JobId == jobId);
            if (campaignJob == null)
                return response.SetBadRequest("Campaign Job not found !!");

            var candidates = await _unitOfWork.Candidates.GetAllAsync(c => c.CampaignJobId == campaignJob.Id);

            var responseList = _mapper.Map<List<CandidateResponse>>(candidates);

            return response.SetOk(responseList);
        }
        public async Task<ApiResponse> UpdateCandidateAsync(CandidateUpdateRequest request)
        {
            var response = new ApiResponse();
            var candidate = await _unitOfWork.Candidates.GetAsync(x => x.Id == request.Id);
            if (candidate == null)
            {
                return response.SetBadRequest("Candidate not found");
            }
            _mapper.Map(request, candidate);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(candidate);
        }

        public async Task<ApiResponse> DeleteCandidateAsync(int id)
        {
            var response = new ApiResponse();

            var candidate = await _unitOfWork.Candidates.GetAsync(x => x.Id == id);
            candidate.IsDeleted = true;
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Remove Sucess !");

        }
    }
}
