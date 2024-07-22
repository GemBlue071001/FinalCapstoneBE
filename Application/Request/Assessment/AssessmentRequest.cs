
namespace Application.Request.Assessment
{
    public class AssessmentRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public int EstimateTime { get; set; }
        //public string Status { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        //public int ActualTime { get; set; }
        public DateTime Deadline { get; set; }
        //Navigation Property
        public int UserId { get; set; }
        public int? TrainingProgramId { get; set; }
    }
}
