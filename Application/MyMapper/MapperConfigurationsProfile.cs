using Application.Request.JobPost;
using Application.Request.SeekerProfile;
using Application.Request.User;
using Application.Response.JobPost;
using Application.Response.User;
using AutoMapper;
using Domain.Entities;

namespace Application.MyMapper
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            CreateMap<UserAccount, UserResponse>().ReverseMap();

            //JobPost
            CreateMap<JobPostRequest, JobPost>();
            CreateMap<JobPost, JobPostResponse>();

            //SeekerProfile
            CreateMap<SeekerProfileRequest, SeekerProfile>();

        }
    }
}
