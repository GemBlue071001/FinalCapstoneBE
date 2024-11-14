using Application.Request.Subscription;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ISubscriptionService
    {
        Task<ApiResponse> GetAllSubscriptionAsync(int UserId);
    }
}
