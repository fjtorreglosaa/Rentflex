namespace Rentflex.Domain.Models
{
    public class Order : Entity
    {
        public string? Reference { get; set; }
        public decimal? Discount { get; set; }
        public Guid? RentalId { get; set; }
        public Rental? Rental { get; set; }
    }
}
