﻿using Application.Request.Assessment;
using Application.Request.Campaign;
using Application.Request.Candidate;
using Application.Request.Job;
using Application.Request.Resource;
using Application.Request.TrainingProgram;
using Application.Response.Assessment;
using Application.Response.Campaign;
using Application.Response.Candidate;
using Application.Response.Job;
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
            CreateMap<Job, JobResponse>().ReverseMap();
            CreateMap<JobResponse, Job>().ReverseMap();

            CreateMap<Campaign, CampaignRequest>().ReverseMap();
            CreateMap<Campaign, CampaignResponse>().ReverseMap();


            CreateMap<Candidate, CandidateRequest>().ReverseMap();
            CreateMap<Candidate, CandidateResponse>().ReverseMap();

            CreateMap<TrainingProgram, TrainingProgramRequest>().ReverseMap();
            CreateMap<TrainingProgram, TrainingProgramResponse>().ReverseMap();

            CreateMap<Assessment, AssessmentRequest>().ReverseMap();
            CreateMap<Assessment, AssessmentResponse>().ReverseMap();

            CreateMap<UserAccount, UserResponse>().ReverseMap();

            CreateMap<Resource, ResourceResponse>().ReverseMap();
            CreateMap<Resource, ResourceRequest>().ReverseMap();
            CreateMap<TrainingProgramResource, TrainingProgramResourceResponse>().ReverseMap();
        }
    }
}
