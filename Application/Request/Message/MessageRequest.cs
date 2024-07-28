using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Message
{
    public class MessageRequest
    {
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public int ConversationId { get; set; }
        public int UserId { get; set; }
    }
}
