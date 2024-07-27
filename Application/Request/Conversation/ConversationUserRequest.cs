using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Conversation
{
    public class ConversationUserRequest
    {
        public int ConversationId { get; set; }
        public int UserId { get; set; }
    }
}
