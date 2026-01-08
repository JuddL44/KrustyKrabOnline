using Microsoft.VisualBasic;

namespace server.Domain.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Icon { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}
