using Application.Response.JobType;
using Application.Response.Location;
using Application.Response.SkillSet;
using System.Text.Json.Serialization;

namespace Application.Response.UserJobAlertCriteria
{
    public class UserJobAlertCriteriaResponse
    {
        public int Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string JobTitle { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? MinSalary { get; set; } = null;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? MaxSalary { get; set; } = null;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LocationResponse Location { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SkillSetResponse SkillSet { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public JobTypeResponse JobType { get; set; }

        public int UserId { get; set; }
    }
}
