using Application.Response.AssessmentSubmition;
using Application.Response.User;
using Domain.Entities;
using System.Text.Json.Serialization;

namespace Application.Response.Assessment

{
    public class AssessmentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Deadline { get; set; }
        public int EstimateTime { get; set; }
        public int ActualTime { get; set; }
        public int TrainingProgramId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AssessmentStatus AssessmentStatus { get; set; }
        public string Comment { get; set; } = string.Empty;

        //Navigation Property
        public int UserId { get; set; }
        public UserResponse Owner { get; set; }
        public List<AssessmentSubmitionResponse> AssessmentSubmitions { get; set; }
    }
}
