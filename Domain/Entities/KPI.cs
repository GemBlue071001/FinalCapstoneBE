﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KPI
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Value { get; set; }
        public string Descition { get; set; }
        public string Type { get; set; }

        //
        public List<ProgramKPI> ProgramKPI { get; set; }
       
    }
}
