using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.User
{
    public class UserResultResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Total { get; set; }
        public List<UserResultDetailResponse> UserResultDetails { get; set; }
    }

    public class UserResultDetailResponse
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public int Weight { get; set; }
    }
}
