namespace Application.Response.AnalyzedResult
{
    public class CVAnalysisResponse
    {
        public string status { get; set; }
        public Data data { get; set; }
        public FileInfo file_info { get; set; }
        public string parser_used { get; set; }
        public string message { get; set; }
    }

    public class Data
    {
        public Personal personal { get; set; }
        public Professional professional { get; set; }
    }

    public class Education
    {
        public object qualification { get; set; } // Change List<string> to object to handle both array and object types
        public List<string> university { get; set; }
        public object course { get; set; }
        public List<string> certificate { get; set; }
    }

    public class Experience
    {
        public List<string> company { get; set; }
        public object projects { get; set; }
        public List<string> role { get; set; }
        public List<string> years { get; set; }
        //public List<string> project_experience { get; set; }
    }

    public class FileInfo
    {
        public string filename { get; set; }
        public string file_url { get; set; }
        public string file_type { get; set; }
    }

    public class Personal
    {
        public List<string> name { get; set; }
        public List<string> contact { get; set; }
        public List<string> email { get; set; }
        public List<string> location { get; set; }
        public List<string> linkedin { get; set; }
        public List<string> github { get; set; }
        public List<string> other_links { get; set; }
    }

    public class Professional
    {
        public List<string> technical_skills { get; set; }
        public List<string> non_technical_skills { get; set; }
        public List<string> tools { get; set; }
        public List<Experience> experience { get; set; }
        public List<Education> education { get; set; }
    }
}
