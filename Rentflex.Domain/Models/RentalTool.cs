namespace Rentflex.Domain.Models
{
    public class RentalTool : Entity
    {
        public Guid? RentalId { get; set; }
        public Rental? Rental { get; set; }
        public Guid? ToolId { get; set; }
        public Tool? Tool { get; set; }
    }
}
