using Application.Request;
using Application.Request.Benefit;
using Application.Request.BusinessStream;

using Application.Request.Company;
using Application.Request.CV;
using Application.Request.EducationDetail;
using Application.Request.ExperienceDetail;
using Application.Request.FollowCompany;
using Application.Request.FollowJob;
using Application.Request.JobLocation;
using Application.Request.JobPost;
using Application.Request.JobPostActivity;
using Application.Request.JobPostActivityComment;
using Application.Request.JobType;
using Application.Request.SeekerProfile;
using Application.Request.SkillSet;
using Application.Request.User;
using Application.Request.UserJobAlertCriteria;
using Application.Response;
using Application.Response.Benefit;
using Application.Response.BusinessStream;
using Application.Response.Company;
using Application.Response.CV;
using Application.Response.FollowCompany;
using Application.Response.FollowJob;
using Application.Response.JobLocation;
using Application.Response.JobPost;
using Application.Response.JobPostActivity;
using Application.Response.JobPostActivityComment;
using Application.Response.JobType;
using Application.Response.Location;
using Application.Response.SeekerProfile;
using Application.Response.SkillSet;
using Application.Response.Subscription;
using Application.Response.User;
using Application.Response.UserJobAlertCriteria;
using AutoMapper;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Domain.Entities;

namespace Application.MyMapper
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            //User
            CreateMap<UserAccount, UserResponse>().ReverseMap();
            CreateMap<SeekerSkillSetRequest, SeekerSkillSet>();
            CreateMap<UpdateUserRequest, UserAccount>();

            CreateMap<UserAccount, UserProfileResponse>()
                            .ForMember(
                              dest => dest.SkillSets,
                              opt => opt.MapFrom(src => src.SeekerSkillSets != null ? src.SeekerSkillSets
                              .Where(x => x.SkillSet != null)
                              .Select(x => new SkillSetResponse
                              {
                                  Id = x.SkillSet.Id,
                                  Name = x.SkillSet.Name,
                                  Description = x.SkillSet.Description,
                                  ProficiencyLevel = x.ProficiencyLevel,
                                  Shorthand = x.SkillSet.Shorthand
                              }).ToList() : new List<SkillSetResponse>())
                            )
                            .ForMember(
                                    dest => dest.Benefits,
                                    opt => opt.MapFrom(src => src.SeekerBenefits
                                   .Select(x => x.Benefit)
                                   .ToList()));

            //JobPost
            CreateMap<JobPostRequest, JobPost>();
            CreateMap<JobPost, JobPostResponse>()
                       .ForMember(dest => dest.CompanyName,
                                   opt => opt.MapFrom(src => src.Company.CompanyName))
                       .ForMember(dest => dest.JobLocationCities,
                                   opt => opt.MapFrom(src => src.JobLocations != null ? src.JobLocations.Select(x => x.Location!.City).ToList() : new List<string>()))
                       .ForMember(dest => dest.JobLocationAddressDetail,
                                   opt => opt.MapFrom(src => src.JobLocations != null ? src.JobLocations.Select(x => x.StressAddressDetail).ToList() : new List<string>()))
                        .ForMember(
                                   dest => dest.SkillSets,
                                    opt => opt.MapFrom(src => src.JobSkillSets
                                   .Select(x => x.SkillSet.Name)
                                   .ToList()))
                        .ForMember(
                                   dest => dest.SkillSetObjects,
                                    opt => opt.MapFrom(src => src.JobSkillSets
                                   .Select(x => x.SkillSet)
                                   .ToList()))
                        .ForMember(
                                   dest => dest.CompanyId,
                                   opt => opt.MapFrom(src => src.Company.Id))
                        .ForMember(
                                    dest => dest.WebsiteCompanyURL,
                                    opt => opt.MapFrom(src => src.Company.WebsiteURL))
                        .ForMember(
                                   dest => dest.BenefitObjects,
                                    opt => opt.MapFrom(src => src.JobPostBenefits
                                   .Select(x => x.Benefit)
                                   .ToList()));

            //CreateMap<UserAccount, CandidateResponse>()
            //            .ForMember(dest => dest.CVPath,
            //                        opt => opt.MapFrom(src => src.JobPostActivitys
            //                                    .Select(x => x.CV.Url)))
            //            .ForMember(dest => dest.JobPostActivityId,
            //                        opt => opt.MapFrom(src => src.JobPostActivitys.Select(x => x.JobPostId)));


            //JobLocation
            CreateMap<JobLocationRequest, JobLocation>();
            CreateMap<JobLocation, JobLocationResponse>();

            //JobType
            CreateMap<JobTypeRequest, JobType>();
            CreateMap<JobType, JobTypeResponse>();

            //Company
            CreateMap<CompanyRequest, Company>();
            CreateMap<UpdateCompanyRequest, Company>();
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
            CreateMap<JobPostActivityUserRequest, JobPostActivity>();


            //CV
            CreateMap<CVRequest, CV>();
            CreateMap<CV, CVResponse>();
            //FollowCompany
            CreateMap<FollowCompanyRequest, FollowCompany>();
            CreateMap<FollowCompany, FollowCompanyResponse>();
            //FollowJob
            CreateMap<FollowJobRequest, FollowJob>();
            CreateMap<FollowJob, FollowJobResponse>();
            //JobPostActivityComment
            CreateMap<JobPostActivityCommentRequest, JobPostActivityComment>();
            CreateMap<JobPostActivityComment, JobPostActivityCommentResponse>();
            CreateMap<UpdateJobPostActivityCommentRequest, JobPostActivityComment>();
            //
            CreateMap<Subscription, SubscriptionResponse>();

            CreateMap<UserJobAlertCriteriaRequest, UserJobAlertCriteria>();
            CreateMap<UserJobAlertCriteria, UserJobAlertCriteriaResponse>();


            CreateMap<Location, LocationResponse>();
            CreateMap<UserJobAlertCriteria, UserJobAlertCriteriaResponse>();
            //
            CreateMap<BenefitRequest, Benefit>();
            CreateMap<Benefit, BenefitResponse>();

            CreateMap<SeekerBenefitRequest, SeekerBenefit>();


        }
    }
}
