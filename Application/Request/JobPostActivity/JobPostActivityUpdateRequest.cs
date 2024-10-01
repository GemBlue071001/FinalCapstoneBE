using Domain.Entities;

namespace Application.Request.JobPostActivity
{
    public class JobPostActivityUpdateRequest
    {
        public int JobPostActivityId { get; set; }
        public JobPostActivityStatus? Status { get; set; }
    }
}
