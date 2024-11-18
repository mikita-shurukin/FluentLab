namespace FluentLab.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int? TopicId { get; set; } // Связь с темой
        public int? TestId { get; set; } // Связь с тестом
        public string Text { get; set; }
        public string QuestionType { get; set; } // MultipleChoice, TrueFalse
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Topic Topic { get; set; }
        public Test Test { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }


}
