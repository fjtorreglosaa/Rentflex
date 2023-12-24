namespace Rentflex.Domain.Models
{
    public class Payment : Entity
    {
        public string? PaymentReference { get; set; }
        public DateTime? PaymentCut { get; set; }
        public Guid? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
