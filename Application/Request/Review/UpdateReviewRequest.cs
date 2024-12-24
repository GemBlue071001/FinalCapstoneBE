using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Review
{
    public class UpdateReviewRequest
    {
        public int Id { get; set; }
        public string ReasonToReject { get; set; }
    }
}
