

namespace Application.Request.Campaign
{
    public class UpdateCampainRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ScopeOfWork { get; set; }
        public string? Requirements { get; set; }
        public int Duration { get; set; }
        public string? ImagePath { get; set; }
    }
}
