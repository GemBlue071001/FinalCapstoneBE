using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FeedBack : Base
    {
        
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public StatusFeedBack StatusFeedBack { get; set; }
        //
        public int UserId { get; set; }
        public UserAccount UserAccount { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
    public enum StatusFeedBack
    {
        Pending,
        Approve,
        Reject,
    }
}
