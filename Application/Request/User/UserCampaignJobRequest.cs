using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.User
{
    public class UserCampaignJobRequest
    {
        public int UserId { get; set; }
        public int CampaginId { get; set; }
        public int JobId { get; set; }
    }
}
