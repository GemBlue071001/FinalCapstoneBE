﻿using Application.Request.JobPost;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IJobPostService
    {
        Task<ApiResponse> AddNewJobPostAsync(JobPostRequest jobPostRequest);
        Task<ApiResponse> GetJobPostAsync();
    }
}