using Application.Request.TrainingProgram;
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

        }
    }
}
