using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Response.JobPostActivity
{
    public class JobPostActivityResponse
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public JobPostActivityStatus Status { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int JobPostId { get; set; }
    }
}
