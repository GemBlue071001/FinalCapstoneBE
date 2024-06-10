using Application.Interface;
using Application.Request.Campaign;
using Application.Response;
using Application.Response.Campaign;
using Application.Response.Job;
using AutoMapper;
using Domain.Entities;

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
            var jobs = await _unitOfWork.Jobs.GetAllAsync(u => request.JobIds.Contains(u.Id));

            var campaign = _mapper.Map<Campaign>(request);
            var lisOfCampaignJob = new List<CampaignJob>();

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
            var campaigns = await _unitOfWork.Campaigns.GetAllCampaign();

            var resposeList = new List<CampaignResponse>();
            foreach (var campaign in campaigns)
            {
                var listProgramResponse = new List<JobResponse>();
                foreach (var program in campaign.CampaignJobs)
                {
                    var programResponse = _mapper.Map<JobResponse>(program.Job);
                    listProgramResponse.Add(programResponse);
                }

                resposeList.Add(new CampaignResponse
                {
                    Id = campaign.Id,
                    Duration = campaign.Duration,
                    Name = campaign.Name,
                    Requirements = campaign.Requirements,
                    ScopeOfWork = campaign.ScopeOfWork,
                    Jobs = listProgramResponse,
                    ImagePath = campaign.ImagePath,

                });
            }

            return response.SetOk(resposeList);
        }
    }
}
