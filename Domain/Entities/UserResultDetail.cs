using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserResultDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public int Weight { get; set; }

        public int UserResultId { get; set; }
        public UserResult UserResult { get; set; }
    }
}
