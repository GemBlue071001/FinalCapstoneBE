﻿

namespace Domain.Entities
{
    public class CV
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string? Name { get; set; }
        public string ExtractedInfo { get; set; } = string.Empty;
        //Navigation Property
        public int? UserId { get; set; }
        public UserAccount UserAccount { get; set; }
        public List<JobPostActivity> JobPostActivitys { get; set; }
    }
}
