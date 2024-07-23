
using Domain.Entities;
using System.Text.Json.Serialization;

namespace Application.Request.Assessment
{
    public class AssessmentUpdateStatusRequest
    {
        public int Id { get; set; }
        
        public AssessmentStatus Status { get; set; }
    }
}
