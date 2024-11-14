using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.Subscription
{
    public class SubscriptionResponse
    {
        public int Id { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public double PaymentAmount { get; set; }
        //Navigation Property
        public int UserId { get; set; }
    }
}
