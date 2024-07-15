using Application.Response.AssessmentSubmition;
using Application.Response.User;
using Domain.Entities;

namespace Application.Response.Assessment

{
    public class AssessmentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public int EstimateTime { get; set; }
        public DateTime EndDate { get; set; }
        public int ActualTime { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public UserResponse Owner { get; set; }
        public List<AssessmentSubmitionResponse> AssessmentSubmitions { get; set; }
    }
}
