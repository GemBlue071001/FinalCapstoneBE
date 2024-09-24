using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response
{
    public class EducationDetailResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string InstitutionName { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public string FieldOfStudy { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal GPA { get; set; }
    }
}
