using Application.Request.Assessment;
using Application.Request.Campaign;
using Application.Request.Candidate;
using Application.Request.Job;
using Application.Request.Meeting;
using Application.Request.Resource;
using Application.Request.TrainingProgram;
using Application.Response.Assessment;
using Application.Response.Campaign;
using Application.Response.Candidate;
using Application.Response.Job;
using Application.Response.MeetingResponse;
using Application.Response.Resource;
using Application.Response.TrainingProgram;
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

            CreateMap<Job, JobRequest>().ReverseMap();
            //CreateMap<Job, JobResponse>().ReverseMap();
            CreateMap<Job, JobResponse>()
                .ForMember(dest => dest.TrainingPrograms, opt => opt.MapFrom(src => src.JobTrainingPrograms.Select(tpr => tpr.TrainingProgram)));
            CreateMap<JobResponse, Job>();
            CreateMap<JobTrainingProgram, TrainingProgramResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TrainingProgram.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.TrainingProgram.Name))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.TrainingProgram.Duration))
                .ForMember(dest => dest.CourseObject, opt => opt.MapFrom(src => src.TrainingProgram.CourseObject))
                .ForMember(dest => dest.OutputObject, opt => opt.MapFrom(src => src.TrainingProgram.OutputObject));
            CreateMap<JobResponse, Job>();

            CreateMap<Campaign, CampaignRequest>().ReverseMap();
            CreateMap<Campaign, CampaignResponse>().ReverseMap();


            CreateMap<Candidate, CandidateRequest>().ReverseMap();
            CreateMap<Candidate, CandidateResponse>().ReverseMap();

            #region TrainingProgram
            CreateMap<TrainingProgram, TrainingProgramRequest>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramResponse>()
                .ForMember(dest => dest.Resources, opt => opt.MapFrom(src => src.TrainingProgramResources.Select(tpr => tpr.Resource)));
            CreateMap<TrainingProgramResponse, TrainingProgram>();
            CreateMap<TrainingProgramResource, ResourceResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Resource.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Resource.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Resource.Description))
                .ForMember(dest => dest.FilePath, opt => opt.MapFrom(src => src.Resource.FilePath));
            #endregion

            CreateMap<Assessment, AssessmentRequest>().ReverseMap();
            CreateMap<Assessment, AssessmentResponse>().ReverseMap();

            CreateMap<UserAccount, UserResponse>().ReverseMap();

            CreateMap<Resource, ResourceResponse>().ReverseMap();
            CreateMap<Resource, ResourceRequest>().ReverseMap();
            CreateMap<TrainingProgramResource, TrainingProgramResourceResponse>().ReverseMap();

            CreateMap<MeetingRequest, Meeting>();
            CreateMap<Meeting, MeetingResponse>()
                .ForMember(meeting => meeting.UserMeetings, opt => opt.MapFrom(src => src.UserMeetings.Select(x => new UserMeetingResponse()
                {
                    Id = x.Id,
                    Email = x.User.Email ?? string.Empty,
                    Phone = x.User.PhoneNumber ?? string.Empty,
                    UserName = x.User.UserName ?? string.Empty,
                    Role = x.User.Role.ToString() ?? string.Empty,
                }).ToList()));
            CreateMap<MeetingUpdateRequest, Meeting>()
                .ForMember(meeting => meeting.Id, opt => opt.Ignore());
        }
    }
}
