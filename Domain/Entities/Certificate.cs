

namespace Domain.Entities
{
    public class Certificate
    {
        public int Id { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public string CertificateOrganization { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CertificateURL { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }

        //Navigation Property
        public UserAccount? UserAccount { get; set; }
        public int? UserId { get; set; }
    }
}
