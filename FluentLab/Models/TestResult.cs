using static System.Net.Mime.MediaTypeNames;

namespace FluentLab.Models
{
    public class TestResult
    {
        public int TestResultId { get; set; }
        public string UserId { get; set; } // Связь с AspNetUsers
        public int TestId { get; set; }
        public int Score { get; set; }
        public DateTime TakenAt { get; set; }

        public Test Test { get; set; }
    }

}
