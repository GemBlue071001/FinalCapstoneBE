using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Service : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPost { get; set; }
        public decimal Price { get; set; }
        public bool? isHot { get; set; }
        public List<UserAccountService> UserServices { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}
