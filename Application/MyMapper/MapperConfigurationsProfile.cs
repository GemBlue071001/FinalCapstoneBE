using Application.Request.Award;
using Application.Request.Benefit;
using Application.Request.BusinessStream;

using Application.Request.Company;
using Application.Request.CompanyLocation;
using Application.Request.CV;
using Application.Request.EducationDetail;
using Application.Request.ExperienceDetail;
using Application.Request.Feedback;
using Application.Request.FollowCompany;
using Application.Request.FollowJob;
using Application.Request.JobLocation;
using Application.Request.JobPost;
using Application.Request.JobPostActivity;
using Application.Request.JobPostActivityComment;
using Application.Request.JobType;
using Application.Request.Location;
using Application.Request.SeekerProfile;
using Application.Request.Service;
using Application.Request.SkillSet;
using Application.Request.User;
using Application.Request.UserJobAlertCriteria;
using Application.Response;
using Application.Response.Award;
using Application.Response.Benefit;
using Application.Response.BusinessStream;
using Application.Response.Company;
using Application.Response.CompanyLocation;
using Application.Response.CV;
using Application.Response.Feedback;
using Application.Response.FollowCompany;
using Application.Response.FollowJob;
using Application.Response.JobLocation;
using Application.Response.JobPost;
using Application.Response.JobPostActivity;
using Application.Response.JobPostActivityComment;
using Application.Response.JobType;
using Application.Response.Location;
using Application.Response.SeekerProfile;
using Application.Response.Service;
using Application.Response.SkillSet;
using Application.Response.Subscription;
using Application.Response.User;
using Application.Response.UserAccountService;
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
                                        .ToList())
                             )
                            .ForMember(
                                         dest => dest.UserAccountServices,
                                         opt => opt.MapFrom(src => src.UserServices != null
                                         ? src.UserServices
                                         .Select(uas => new UserAccountServiceResponse
                                         {
                                             Id = uas.Id,
                                             NumberOfPostLeft = uas.NumberOfPostLeft,
                                             ServiceResponse = new ServiceResponse
                                             {
                                                 Id = uas.Service.Id,
                                                 Name = uas.Service.Name,
                                                 Description = uas.Service.Description,
                                                 NumberOfPost = uas.Service.NumberOfPost,
                                                 Price = uas.Service.Price
                                             }
                                         }).ToList()
                                    : new List<UserAccountServiceResponse>())
                             );

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
                                   .ToList()))
                        .ForMember(
                                   dest => dest.LocationObjects,
                                    opt => opt.MapFrom(src => src.JobLocations
                                   .Select(x => x.Location)
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

            CreateMap<Award, AwardResponse>();

            //JobType
            CreateMap<JobTypeRequest, JobType>();
            CreateMap<JobType, JobTypeResponse>();

            //Company
            CreateMap<CompanyRequest, Company>();
            CreateMap<CompanyLocationRequest, CompanyLocation>();
            CreateMap<CompanyLocation, CompanyLocationResponse>();
            CreateMap<UpdateCompanyRequest, Company>();
            CreateMap<UpdateCompanyRejectRequest, Company>();

            CreateMap<Company, CompanyResponse>();
            CreateMap<CompanyLocation, CompanyLocationResponse>()
                    .ForMember(dest => dest.City, opt =>
                     opt.MapFrom(src => src.Location != null ? src.Location.City : string.Empty));

            //Education Detail
            CreateMap<EducationDetailRequest, EducationDetail>();
            CreateMap<EducationDetail, EducationDetailResponse>();


            //Award
            CreateMap<AddAwardRequest, Award>();

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


            
            CreateMap<UserJobAlertCriteria, UserJobAlertCriteriaResponse>();
            //
            CreateMap<BenefitRequest, Benefit>();
            CreateMap<Benefit, BenefitResponse>();

            CreateMap<SeekerBenefitRequest, SeekerBenefit>();

            //Review
            CreateMap<ReviewRequest, Review>();
            CreateMap<Review, ReviewReponse>()
                .ForMember(dest => dest.CompanyNName, opt => opt.MapFrom(src => src.Company.CompanyName));

            //Service
            CreateMap<ServiceRequest, Service>();
            CreateMap<Service, ServiceResponse>();

            //Location
            CreateMap<Location, LocationResponse>();
            CreateMap<LocationRequest, Location>();

        }
    }
}
