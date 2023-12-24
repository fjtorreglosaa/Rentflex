namespace Rentflex.Domain.Models
{
    public class ToolPrice : Entity
    {
        public decimal? Price { get; set; }
        public Guid? PeriodId { get; set; }
        public Period? Period { get; set; }
        public bool? Active { get; set; }
    }
}
