using Application.Response.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.UserAccountService
{
    public class UserAccountServiceResponse
    {
        public int Id { get; set; }
        public int NumberOfPostLeft { get; set; }
        public ServiceResponse ServiceResponse { get; set; }
    }
}
