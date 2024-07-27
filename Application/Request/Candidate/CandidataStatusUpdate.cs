using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Candidate
{
    public class CandidataStatusUpdate
    {
        public int Id { get; set; }
        public CandidateStatus CandidateStatus { get; set; }
    }
}
