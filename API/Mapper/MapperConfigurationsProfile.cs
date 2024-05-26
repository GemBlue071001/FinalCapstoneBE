using Application.Response.UserResponse;
using AutoMapper;
using Domain.Entities;

namespace API.Mapper
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            CreateMap<UserAccount, UserResponse>().ReverseMap();

        }
    }
}
