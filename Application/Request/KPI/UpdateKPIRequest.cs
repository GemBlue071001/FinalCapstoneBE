

namespace Application.Request.KPI
{
    public class UpdateKPIRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Descition { get; set; }
        public string Type { get; set; }
    }
}
