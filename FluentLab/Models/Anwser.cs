namespace FluentLab.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Question Question { get; set; }
    }

}
