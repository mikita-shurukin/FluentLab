namespace FluentLab.Models
{
    public class Test
    {
        public int TestId { get; set; }
        public int? CategoryId { get; set; } 
        public string Name { get; set; }
        public string Level { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Category Category { get; set; }
        public ICollection<Question> Questions { get; set; } 
    }

}
