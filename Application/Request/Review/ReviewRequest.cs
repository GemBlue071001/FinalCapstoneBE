using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Feedback
{
    public class ReviewRequest
    {
        [Range(1, 5, ErrorMessage = "Salary Rating must be between 1 and 5")]
        public int SalaryRating { get; set; }

        [Range(1, 5, ErrorMessage = "Training Rating must be between 1 and 5")]
        public int TrainingRating { get; set; }

        [Range(1, 5, ErrorMessage = "Care Rating must be between 1 and 5")]
        public int CareRating { get; set; }

        [Range(1, 5, ErrorMessage = "Culture Rating must be between 1 and 5")]
        public int CultureRating { get; set; }

        [Range(1, 5, ErrorMessage = "Office Rating must be between 1 and 5")]
        public int OfficeRating { get; set; }

        public string SummaryContent { get; set; }
        public string ReviewContent { get; set; }
        public string ReasonContent { get; set; }
        public string ExperienceContent { get; set; }
        public string SuggestionContent { get; set; }

        public bool Recommened { get; set; }
        public int CompanyId { get; set; }
    }
}
