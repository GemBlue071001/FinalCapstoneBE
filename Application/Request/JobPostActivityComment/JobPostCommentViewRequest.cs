using Application.Request.Paginations;

namespace Application.Request.JobPostActivityComment
{
    public class JobPostCommentViewRequest: PaginationRequest
    {
        public int Id { get; set; }
    }
}
