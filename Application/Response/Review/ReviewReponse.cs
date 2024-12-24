using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.Feedback
{
    public class ReviewReponse
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int SalaryRating { get; set; }
        public int TrainingRating { get; set; }
        public int CareRating { get; set; }
        public int CultureRating { get; set; }
        public int OfficeRating { get; set; }
        public string SummaryContent { get; set; }
        public string ReviewContent { get; set; }
        public string ReasonContent { get; set; }
        public string ExperienceContent { get; set; }
        public string SuggestionContent { get; set; }
        public bool Recommened { get; set; }

        public string CompanyNName { get; set; }
    }
}
