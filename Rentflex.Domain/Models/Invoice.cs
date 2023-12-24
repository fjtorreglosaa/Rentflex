namespace Rentflex.Domain.Models
{
    public class Invoice : Entity
    {
        public Invoice()
        {
            Rentals = new HashSet<Rental>();
            Payments = new HashSet<Payment>();
        }

        public string? InvoiceReference { get; set; }
        public DateTime? Cut { get; set; }
        public Guid? PaymentTypeId { get; set; }
        public PaymentType? PaymentType { get; set; }
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }
        public ICollection<Rental> Rentals { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
