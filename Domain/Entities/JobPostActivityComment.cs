namespace Domain.Entities
{
    public class JobPostActivityComment
    {
        public int Id { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int? Rating { get; set; }


        //Navigation Property
        public int JobPostActivityId { get; set; }
        public JobPostActivity JobPostActivity { get; set; }

    }
}
