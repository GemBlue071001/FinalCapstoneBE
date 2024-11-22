namespace Application.Request.CV
{
    public class ExtractedCVData
    {
        public List<MappedData> Data { get; set; }
        public bool success { get; set; }
    }
    public class MappedData
    {
        public MappedPersonal personal { get; set; }
        public MappedProfessional professional { get; set; }
    }

    public class MappedPersonal
    {
        public List<string> contact { get; set; }
        public List<string> email { get; set; }
        public List<string> github { get; set; }
        public List<string> linkedin { get; set; }
        public List<string> location { get; set; }
        public List<string> name { get; set; }
    }

    public class MappedProfessional
    {
        public List<MappedEducation> education { get; set; }
        public List<MappedExperience> experience { get; set; }
        public List<string> technical_skills { get; set; }
        public List<string> non_technical_skills { get; set; }
        public List<string> tools { get; set; }
    }

    public class MappedEducation
    {
        public List<string> qualification { get; set; }
        public List<string> university { get; set; }
    }

    public class MappedExperience
    {
        public List<string> company { get; set; }
        public List<string> role { get; set; }
        public List<string> years { get; set; }
        public List<string> project_experience { get; set; }
    }
}
