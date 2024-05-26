using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService
    {
        private IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ApiResponse GetUserProfileAsync(int id)
        {
            ApiResponse response = new ApiResponse();

            var user = _unitOfWork.UserAccounts.GetAsync(u => u.Id == id);
            if (user == null)
                return response.SetNotFound("User not found");
            else
            {

            }
            return null;
        }
    }
}
