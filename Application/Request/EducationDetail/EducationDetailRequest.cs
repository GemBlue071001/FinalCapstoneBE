namespace Application.Request.EducationDetail
{
    public class EducationDetailRequest
    {
        public string Name { get; set; } = string.Empty;
        public string InstitutionName { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public string FieldOfStudy { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal GPA { get; set; }
        //public int SeekerProfileId { get; set; }
    }

    public class UpdateEducationDetailRequest : EducationDetailRequest
    {
        public int Id { get; set; }
    }
}
