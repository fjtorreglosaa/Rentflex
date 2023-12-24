namespace Rentflex.Domain.Models
{
    public class RentCustomer : Entity
    {
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool? CompanyCustomer { get; set; }
    }
}
