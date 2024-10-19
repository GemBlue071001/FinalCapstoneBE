using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.JobPostActivityComment
{
    public class UpdateJobPostActivityCommentRequest
    {
        public int Id { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int? Rating { get; set; }
    }
}
