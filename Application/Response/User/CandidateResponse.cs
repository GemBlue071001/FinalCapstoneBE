﻿using Application.Request.CV;
using Application.Response.AnalyzedResult;
using Application.Response.JobPostActivityComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.User
{
    public class CandidateResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int? CVId { get; set; }
        public string CVPath { get; set; } = string.Empty;
        public ExtractedCVData ExtractedCVInfo { get; set; }
        public int? JobPostActivityId { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<JobPostActivityCommentResponse> JobPostActivityComments { get; set; } = new List<JobPostActivityCommentResponse>();
        public AnalyzedResultResponse AnalyzedResult { get; set; } = new AnalyzedResultResponse();
    }
}
