using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Assessment : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public int EstimateTime { get; set; }
        public DateTime EndDate { get; set; }
        public int ActualTime { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public UserAccount Owner { get; set; }

    }
}
