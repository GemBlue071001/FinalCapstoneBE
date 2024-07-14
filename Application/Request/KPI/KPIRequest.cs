using Domain.Entities;
namespace Application.Request.KPI
{
    public class KPIRequest
    {
        public string Name { get; set; }
        //public string Value { get; set; }
        public int Weight { get; set; }
        public string? Type { get; set; }

    }
}
