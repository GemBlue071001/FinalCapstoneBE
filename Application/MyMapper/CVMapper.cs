using Application.Request.CV;
using Application.Response.AnalyzedResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MyMapper
{
    public class CVMapper
    {
        public CVMapper()
        {
            
        }
        public UploadCVJsonRequest MapToCVJsonRequest(CVAnalysisResponse source)
        {
            if (source == null || source.data == null)
            {
                return new UploadCVJsonRequest
                {
                    Data = new List<MappedData>(),
                    success = false
                };
            }

            var mappedData = new MappedData
            {
                personal = source.data.personal != null ? new MappedPersonal
                {
                    contact = source.data.personal.contact ?? new List<string>(),
                    email = source.data.personal.email ?? new List<string>(),
                    github = source.data.personal.github ?? new List<string>(),
                    linkedin = source.data.personal.linkedin ?? new List<string>(),
                    location = source.data.personal.location ?? new List<string>(),
                    name = source.data.personal.name ?? new List<string>()
                } : new MappedPersonal(),

                professional = source.data.professional != null ? new MappedProfessional
                {
                    education = source.data.professional.education != null
                        ? source.data.professional.education.Select(e => new MappedEducation
                        {
                            //qualification = e.qualification ?? new List<string>(),
                            university = e.university ?? new List<string>()
                        }).ToList()
                        : new List<MappedEducation>(),

                    experience = source.data.professional.experience != null
                        ? source.data.professional.experience.Select(ex => new MappedExperience
                        {
                            company = ex.company ?? new List<string>(),
                            role = ex.role ?? new List<string>(),
                            years = ex.years ?? new List<string>(),
                            project_experience = ex.projects != null ? ex.projects.ToString().Split(',').ToList() : new List<string>()
                        }).ToList()
                        : new List<MappedExperience>(),

                    technical_skills = source.data.professional.technical_skills ?? new List<string>(),
                    non_technical_skills = source.data.professional.non_technical_skills ?? new List<string>(),
                    tools = source.data.professional.tools ?? new List<string>()
                } : new MappedProfessional()
            };

            return new UploadCVJsonRequest
            {
                Data = new List<MappedData> { mappedData },
                success = true
            };
        }

    }
}
