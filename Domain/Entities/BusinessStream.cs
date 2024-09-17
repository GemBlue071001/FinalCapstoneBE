using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BusinessStream : Base
    {
        public int Id { get; set; }
        public string BusinessStreamName { get; set; }
        public string Description { get; set; }
        //Navigation Property
        public List<Company> Companys { get; set; }
    }
}
