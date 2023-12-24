namespace Rentflex.Domain.Models
{
    public class ToolImage : Entity
    {
        public string? Name { get; set; }
        public bool? MainImage { get; set; }
        public string? Content { get; set; }
        public Guid? ToolId { get; set; }
        public Tool? Tool { get; set; }
    }
}
