namespace server.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int MenuItemId { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
