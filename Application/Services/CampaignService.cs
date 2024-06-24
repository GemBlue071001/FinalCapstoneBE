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

        public async Task<ApiResponse> DeleteCampaign(int id)
        {
            var response = new ApiResponse();
            var campaign = await _unitOfWork.Campaigns.GetAsync(x => x.Id == id);
            await _unitOfWork.Campaigns.RemoveByIdAsync(id);
            await _unitOfWork.SaveChangeAsync();

            if (campaign == null)
                return response.SetBadRequest("Campaigns Not Found!");
            return response.SetOk(campaign);
        }

        public async Task<ApiResponse> UpdateCampainAsync(UpdateCampainRequest request)
        {
            var response = new ApiResponse();
            var campaign = await _unitOfWork.Campaigns.GetAsync(x => x.Id == request.Id);
            if(campaign == null)
            {
                response.SetBadRequest("Campain not found");
            }
            _mapper.Map(request, campaign);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(campaign);
        }
    }
}
