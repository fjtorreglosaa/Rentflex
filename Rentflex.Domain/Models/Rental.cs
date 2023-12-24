namespace Rentflex.Domain.Models
{
    public class Rental : Entity
    {
        public Rental()
        {
            Tools = new HashSet<RentalTool>();    
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? RentalReference { get; set; }
        public Guid? CustomerId { get; set; }
        public RentCustomer? Customer { get; set; }
        public Guid? OrderId { get; set; }
        public Order? Order { get; set; }
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }
        public Guid? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public ICollection<RentalTool> Tools { get; set; }
    }
}
