using Application.Response.JobType;
using Application.Response.Location;
using Application.Response.SkillSet;
using System.Text.Json.Serialization;

namespace Application.Response.UserJobAlertCriteria
{
    public class UserJobAlertCriteriaResponse
    {
        public int Id { get; set; }
        public string _jobTitle;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string JobTile
        {
            get => string.IsNullOrEmpty(_jobTitle) ? null : _jobTitle;
            set => _jobTitle = value;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal MinSalary { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal MaxSalary { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LocationResponse Location { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SkillSetResponse SkillSet { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public JobTypeResponse JobType { get; set; }

        public int UserId { get; set; }
    }
}
