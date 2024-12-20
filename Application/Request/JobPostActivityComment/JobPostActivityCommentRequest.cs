﻿namespace Application.Request.JobPostActivityComment
{
    public class JobPostActivityCommentRequest
    {
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int? Rating { get; set; }
        //Navigation Property
        public int JobPostActivityId { get; set; }
    }
}
