using Application.Request.Campaign;
using Application.Request.Candidate;
using Application.Request.Job;
using Application.Request.TrainingProgram;
using Application.Response.Campaign;
using Application.Response.Candidate;
using Application.Response.Job;
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

            CreateMap<Job, JobRequest>().ReverseMap();
            CreateMap<Job, JobResponse>().ReverseMap();
            CreateMap<JobResponse, Job>().ReverseMap();

            CreateMap<Campaign, CampaignRequest>().ReverseMap();
            CreateMap<Campaign, CampaignResponse>().ReverseMap();


            CreateMap<Candidate, CandidateRequest>().ReverseMap();
            CreateMap<Candidate, CandidateResponse>().ReverseMap();

            CreateMap<TrainingProgram, TrainingProgramRequest>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramResponse>().ReverseMap();



        }
    }
}
