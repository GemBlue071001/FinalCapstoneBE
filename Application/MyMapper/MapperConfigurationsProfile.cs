using Application.Request.Company;
using Application.Request.JobLocation;
using Application.Request.JobPost;
using Application.Request.JobType;
using Application.Request.SeekerProfile;
using Application.Request.User;
using Application.Response.Company;
using Application.Response.JobLocation;
using Application.Response.JobPost;
using Application.Response.JobType;
using Application.Response.SeekerProfile;
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
            CreateMap<SeekerProfile, SeekerProfileResponse>();

            //JobLocation
            CreateMap<JobLocationRequest, JobLocation>();
            CreateMap<JobLocation, JobLocationResponse>();

            //JobType
            CreateMap<JobTypeRequest, JobType>();
            CreateMap<JobType, JobTypeResponse>();

            //Company
            CreateMap<CompanyRequest, Company>();
            CreateMap<Company, CompanyResponse>();

        }
    }
}
