using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subscription: Base
    {
        public int Id { get; set; }
        //public DateTime ExpiredDate { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public double PaymentAmount { get; set; }
        //Navigation Property
        public UserAccount UserAccount { get; set; }
        public int UserId { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
