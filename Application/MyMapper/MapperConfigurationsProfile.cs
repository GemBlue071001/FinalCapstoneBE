using Application.Request;
using Application.Request.BusinessStream;

using Application.Request.Company;
using Application.Request.CV;
using Application.Request.EducationDetail;
using Application.Request.ExperienceDetail;
using Application.Request.JobLocation;
using Application.Request.JobPost;
using Application.Request.JobPostActivity;
using Application.Request.JobType;
using Application.Request.SeekerProfile;
using Application.Request.SkillSet;
using Application.Request.User;
using Application.Response;
using Application.Response.BusinessStream;
using Application.Response.Company;
using Application.Response.CV;
using Application.Response.JobLocation;
using Application.Response.JobPost;
using Application.Response.JobPostActivity;
using Application.Response.JobType;
using Application.Response.SeekerProfile;
using Application.Response.SkillSet;
using Application.Response.User;
using AutoMapper;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
            CreateMap<JobPost, JobPostResponse>()
                       .ForMember(dest => dest.CompanyName,
                                   opt => opt.MapFrom(src => src.Company.CompanyName))
                        .ForMember(
                                   dest => dest.SkillSets,
                                    opt => opt.MapFrom(src => src.JobSkillSets
                                   .Select(x => x.SkillSet.Name)
                                   .ToList()))
                        .ForMember(
                                   dest => dest.CompanyId,
                                   opt => opt.MapFrom(src => src.Company.Id))
                        .ForMember(
                                    dest => dest.WebsiteCompanyURL,
                                    opt => opt.MapFrom(src => src.Company.WebsiteURL));

            

            //JobLocation
            CreateMap<JobLocationRequest, JobLocation>();
            CreateMap<JobLocation, JobLocationResponse>();

            //JobType
            CreateMap<JobTypeRequest, JobType>();
            CreateMap<JobType, JobTypeResponse>();

            //Company
            CreateMap<CompanyRequest, Company>();
            CreateMap<Company, CompanyResponse>();

            //Education Detail
            CreateMap<EducationDetailRequest, EducationDetail>();
            CreateMap<EducationDetail, EducationDetailResponse>();

            //ExperienceDetail
            CreateMap<ExperienceDetailRequest, ExperienceDetail>();
            CreateMap<ExperienceDetail, ExperienceDetailResponse>();

            //SkillSet
            CreateMap<SkillSetRequest, SkillSet>();
            CreateMap<SkillSet, SkillSetResponse>();
            //
            CreateMap<JobPostActivityRequest, JobPostActivity>();

            //
            CreateMap<BusinessStreamRequest, BusinessStream>();
            CreateMap<BusinessStream, BusinessStreamResponse>();

            //JobPostActivity
            CreateMap<JobPostActivityRequest, JobPostActivity>();
            CreateMap<JobPostActivity, JobPostActivityResponse>()
                            .ForMember(
                                    dest => dest.ImageURL,
                                    opt => opt.MapFrom(src => src.JobPost.ImageURL))
                            .ForMember(
                                    dest => dest.JobTitle,
                                    opt => opt.MapFrom(src => src.JobPost.JobTitle));
                            

            //CV
            CreateMap<CVRequest, CV>();
            CreateMap<CV, CVResponse>();

        }
    }
}
