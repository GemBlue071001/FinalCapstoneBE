using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Attendance : Base
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public AttendanceStatus Status { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public UserAccount User { get; set; }
        public int CampaignJobId { get; set; }
        public CampaignJob CampaignJob { get; set; }
    }
    public enum AttendanceStatus
    {
        Present,
        Absent,
        Late,
        Excused
    }
}
