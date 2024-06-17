using Application.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClaimsService : IClaimsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ClaimsService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetUserIdInRequest()
        {
            var _tokenUserId = _httpContextAccessor.HttpContext.User.FindFirst("UserId");
            if (_tokenUserId == null) throw new ArgumentNullException("UserId can not be found!");
            var _userId = Guid.Parse(_tokenUserId?.Value.ToString()!);
            return _userId;
        }
    }
}
