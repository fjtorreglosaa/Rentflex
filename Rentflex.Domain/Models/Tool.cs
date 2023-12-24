namespace Rentflex.Domain.Models
{
    public class Tool : Entity
    {
        public Tool()
        {
            Prices = new HashSet<ToolPrice>();
            Images = new HashSet<ToolImage>();
        }

        public string? Name { get; set; }
        public bool? Active { get; set; }
        public ICollection<ToolPrice>? Prices { get; set; }
        public ICollection<ToolImage>? Images { get; set; }
    }
}
