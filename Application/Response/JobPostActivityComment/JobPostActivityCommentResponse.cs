﻿namespace Application.Response.JobPostActivityComment
{
    public class JobPostActivityCommentResponse
    {
        public int Id { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int? Rating { get; set; }
        public int JobPostActivityId { get; set; }
    }
    public class JobPostActivityCommentOfJobPostActivityResponse
    {
        public int Id { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int? Rating { get; set; }
    }
}
