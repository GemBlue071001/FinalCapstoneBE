namespace Application.Request.Certificate
{
    public class UpdateCertificateRequest
    {
        public int Id { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public string CertificateOrganization { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CertificateURL { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
    }
}
