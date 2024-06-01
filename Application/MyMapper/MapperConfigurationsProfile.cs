using Application.Request.Campaign;
using Application.Request.TrainingProgram;
using Application.Response.Campaign;
using Application.Response.TrainingProgram;
using Application.Response.UserResponse;
using AutoMapper;
using Domain.Entities;

namespace Application.MyMapper
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            CreateMap<UserAccount, UserResponse>().ReverseMap();

            CreateMap<TrainingProgram, TrainingProgramRequest>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramResponse>().ReverseMap();
            CreateMap<TrainingProgramResponse, TrainingProgram>().ReverseMap();

            CreateMap<Campaign, CampaignRequest>().ReverseMap();
            CreateMap<Campaign, CampaignResponse>().ReverseMap();


        }
    }
}
