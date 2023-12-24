namespace Rentflex.Domain.Models
{
    public class Period : Entity
    {
        public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
