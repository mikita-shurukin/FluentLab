namespace FluentLab.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Topic> Topics { get; set; }
        public ICollection<Test> Tests { get; set; }
    }

}
