namespace FluentLab.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Навигационные свойства
        public Category Category { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}

