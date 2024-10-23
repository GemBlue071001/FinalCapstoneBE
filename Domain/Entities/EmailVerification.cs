namespace Domain.Entities
{
    public class EmailVerification
    {
        public int Id { get; set; }
        public string VerificationCode{ get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }

        //navigation property
        public int UserId { get; set; }
        public UserAccount User { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
