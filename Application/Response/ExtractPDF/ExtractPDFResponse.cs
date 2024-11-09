using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.ExtractPDF
{
    public class ExtractPDFResponse
    {
        public string Status { get; set; }
        public Data Data { get; set; }
        public FileInfo FileInfo { get; set; }
        public string ProcessFile { get; set; }
        public string Message { get; set; }
    }
    public class Data
    {
        public Personal Personal { get; set; }
        public Professional Professional { get; set; }
    }

    public class Personal
    {
        public List<string> Name { get; set; }
        public string Contact { get; set; }
        public List<string> Email { get; set; }
        public List<string> Location { get; set; }
        public List<string> Linkedin { get; set; }
        public string Github { get; set; }
        public List<string> OtherLinks { get; set; }
    }

    public class Professional
    {
        public List<string> TechnicalSkills { get; set; }
        public string NonTechnicalSkills { get; set; }
        public List<string> Tools { get; set; }
        public List<Experience> Experience { get; set; }
        public List<Education> Education { get; set; }
    }

    public class Experience
    {
        public List<string> Company { get; set; }
        public string Projects { get; set; }
        public List<string> Role { get; set; }
        public List<string> Years { get; set; }
        public List<string> ProjectExperience { get; set; }
    }

    public class Education
    {
        public List<string> Qualification { get; set; }
        public List<string> University { get; set; }
        public List<string> Course { get; set; }
        public List<string> Certificate { get; set; }
    }

    public class FileInfo
    {
        public string Filename { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
    }
}
