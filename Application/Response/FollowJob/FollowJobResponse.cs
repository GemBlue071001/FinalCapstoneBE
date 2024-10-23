using Application.Response.Company;
using Application.Response.JobPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.FollowJob
{
    public class FollowJobResponse
    {
        public List<JobPostResponse> JobPosts { get; set; }
    }
}
