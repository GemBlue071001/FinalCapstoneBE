namespace Application.Request.Meeting
{
    public class MeetingRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string Minutes { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

        //Navigation Property 
        public List<int> UserIds = [];
    }
}
