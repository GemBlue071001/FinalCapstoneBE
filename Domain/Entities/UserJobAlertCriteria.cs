namespace Domain.Entities
{
    public class UserJobAlertCriteria
    {
        public int Id { get; set; }
        public string JobTile {  get; set; } = string.Empty;
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }


        // Navigation Property
        public int? LocationId { get; set; }
        public int? SkillSetId { get; set; }
        public int? JobTypeId { get; set; }
        public int? UserId { get; set; }

        public Location? Location { get; set; }
        public SkillSet? SkillSet { get; set; }
        public JobType? JobType { get; set; }
        public UserAccount UserAccount { get; set; }
    }
}
