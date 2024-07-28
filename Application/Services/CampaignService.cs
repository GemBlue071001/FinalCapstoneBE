using Application.Interface;
using Application.Request.Campaign;
using Application.Response;
using Application.Response.Campaign;
using Application.Response.Job;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class CampaignService : ICampaignService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public CampaignService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddCampaign(CampaignRequest request)
        {
            var response = new ApiResponse();
            DateTime date = request.EstimateStartDate.AddMonths(request.Duration);
            var jobs = await _unitOfWork.Jobs.GetAllAsync(u => request.JobIds.Contains(u.Id));

            var campaign = _mapper.Map<Campaign>(request);
            
            var lisOfCampaignJob = new List<CampaignJob>();

            if (campaign.SubmissionDeadline.Date < campaign.EstimateStartDate.Date) 
            {
                return response.SetBadRequest("Submition should before start day");
            }

            foreach (var job in jobs)
            {
                lisOfCampaignJob.Add(new CampaignJob
                {
                    JobId = job.Id,
                    Campaign = campaign
                });
            }
            campaign.CampaignJobs = lisOfCampaignJob;



            await _unitOfWork.Campaigns.AddAsync(campaign);
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetAllCampaign()
        {
            var response = new ApiResponse();
            var campaigns = await _unitOfWork.Campaigns.GetAllAsync(null, x => x.Include(x => x.CampaignJobs)
                                                                        .ThenInclude(x => x.Job));
            var responseList = _mapper.Map<List<CampaignResponse>>(campaigns);

            return response.SetOk(responseList);
        }

        public async Task<ApiResponse> DeleteCampaign(int id)
        {
            var response = new ApiResponse();
            var campaign = await _unitOfWork.Campaigns.GetAsync(x => x.Id == id);
            if (campaign == null)
                return response.SetBadRequest("Campaigns Not Found!");
            await _unitOfWork.Campaigns.RemoveByIdAsync(id);
            await _unitOfWork.SaveChangeAsync();

            
            return response.SetOk(campaign);
        }

        public async Task<ApiResponse> UpdateCampainAsync(UpdateCampainRequest request)
        {
            var response = new ApiResponse();
            var campaign = await _unitOfWork.Campaigns.GetAsync(x => x.Id == request.Id);
            if (campaign == null)
            {
                return response.SetBadRequest("Campain not found");
            }
            _mapper.Map(request, campaign);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(campaign);
        }

        public async Task<ApiResponse> AddJobToCampaignAsync(CampaignJobRequest request)
        {
            var response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(x => x.CampaignId == request.CampaginId &&
                                                                      x.JobId == request.JobId);
            if (campaignJob != null)
            {
                return response.SetBadRequest("Job is already exist in Campagin");
            }

            campaignJob = new CampaignJob()
            {
                JobId = request.JobId,
                CampaignId = request.CampaginId,
            };
            try
            {
                await _unitOfWork.CampaignJobs.AddAsync(campaignJob);
                await _unitOfWork.SaveChangeAsync();
            }
            catch (Exception)
            {
                
                return response.SetBadRequest($"Invalid Request | Job Id: {request.JobId} or Campaign Id: {request.CampaginId} is not existed ");
            }

            return response.SetOk(campaignJob);
        }


        public async Task<ApiResponse> RemoveJobFromCampaignAsync(CampaignJobRequest request)
        {
            var response = new ApiResponse();
            var campaignJob = await _unitOfWork.CampaignJobs.GetAsync(x => x.CampaignId == request.CampaginId &&
                                                                      x.JobId == request.JobId);
            if (campaignJob == null)
            {
                return response.SetBadRequest("Job is not exist in Campagin");
            }

            try
            {
                await _unitOfWork.CampaignJobs.RemoveByIdAsync(campaignJob.Id);
                await _unitOfWork.SaveChangeAsync();
            }
            catch (Exception)
            {

                return response.SetBadRequest($"Delete Fail !");
            }

            return response.SetOk(campaignJob);
        }

    }
}
