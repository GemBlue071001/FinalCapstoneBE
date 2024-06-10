using Application.Interface;
using Application.Request.Candidate;
using Application.Response;
using Application.Response.Candidate;
using AutoMapper;
using Domain.Entities;
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
        public CandidateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddCadidate(CandidateRequest request)
        {
            var response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(p => p.CampaignId == request.CampaignId && 
                                                                          p.JobId == request.JobId);

            if (campaignJob == null)
                return response.SetBadRequest("Campaign Job not found !!");

            var candidate = _mapper.Map<Candidate>(request);
            candidate.CampaignJobId = campaignJob.Id;

            await _unitOfWork.Candidates.AddAsync(candidate);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetProgramCadidate(int campaignId, int jobId)
        {
            var response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(p => p.CampaignId == campaignId &&
                                                                          p.JobId == jobId);
            if (campaignJob == null)
                return response.SetBadRequest("Campaign Job not found !!");

            var candidates = await _unitOfWork.Candidates.GetAllAsync(c=> c.CampaignJobId == campaignJob.Id);

            var responseList = _mapper.Map<List<CandidateResponse>>(candidates);

            return response.SetOk(responseList);
        }
    }
}
