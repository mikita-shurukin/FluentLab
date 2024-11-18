namespace FluentLab.Models
{
    public class UserProgress
    {
        public int Id { get; set; }
        public string UserId { get; set; } 
        public int TopicId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? LastAttempt { get; set; }
        public int Score { get; set; }

        public Topic Topic { get; set; }
    }
}
