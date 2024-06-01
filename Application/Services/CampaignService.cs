using Application.Interface;
using Application.Request.Campaign;
using Application.Response;
using Application.Response.Campaign;
using Application.Response.TrainingProgram;
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
            var trainingPrograms = await _unitOfWork.TrainingPrograms.GetAllAsync(u => request.TrainingProgramIds.Contains(u.Id));
            var campaign = _mapper.Map<Campaign>(request);

            if (trainingPrograms != null|| trainingPrograms.Count>=0)
            {
                var lisOfTrainingProgram = new List<CampaignTrainingProgram>();
                foreach (var program in trainingPrograms)
                {
                    lisOfTrainingProgram.Add(new CampaignTrainingProgram
                    {
                        Campaign = campaign,
                        TrainingProgram = program,
                        TrainingProgramId = program.Id
                    });
                }
                campaign.CampaignTrainingPrograms = lisOfTrainingProgram;
                await _unitOfWork.Campaigns.AddAsync(campaign);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk("Create Success !!");
            }

            return response.SetBadRequest("missing data");
        }

        public async Task<ApiResponse> GetAllCampaign()
        {
            var response = new ApiResponse();
            var campaigns = await _unitOfWork.Campaigns.GetAllCampaign();

            var resposeList = new List<CampaignResponse>();
            foreach (var campaign in campaigns)
            {
                var listProgramResponse = new List<TrainingProgramResponse>();
                foreach (var program in campaign.CampaignTrainingPrograms)
                {
                    //listProgramResponse.Add(new TrainingProgramResponse
                    //{
                    //    Id = program.Id,
                    //});
                    var programResponse = _mapper.Map<TrainingProgramResponse>(program.TrainingProgram);
                    listProgramResponse.Add(programResponse);
                }

                resposeList.Add(new CampaignResponse
                {
                    Id = campaign.Id,
                    Duration = campaign.Duration,
                    Name = campaign.Name,
                    Requirements = campaign.Requirements,
                    ScopeOfWork = campaign.ScopeOfWork,
                    TrainingPrograms = listProgramResponse
                });
            }

            return response.SetOk(resposeList);
        }
    }
}
