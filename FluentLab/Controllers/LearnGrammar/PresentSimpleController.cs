using FluentLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace FluentLab.Controllers.LearnGrammar
{
    public class PresentSimpleController : Controller
    {
        private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FluentLab;Trusted_Connection=True;";




        //[HttpGet]
        //public IActionResult GetQuestions()
        //{
        //    var questions = new List<Question>();
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        connection.Open();

        //        var query = "SELECT TOP 20 * FROM dbo.PresentSimpleQuestions ORDER BY NEWID()";
        //        var command = new SqlCommand(query, connection);

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                questions.Add(new Question
        //                {
        //                    Id = reader.GetInt32(0),
        //                    QuestionText = reader.GetString(1),
        //                    Option1 = reader.GetString(2),
        //                    Option2 = reader.GetString(3),
        //                    Option3 = reader.GetString(4),
        //                    Option4 = reader.GetString(5)
        //                });
        //            }
        //        }
        //    }
        //    return View("GetQuestions", questions);
        //}

        //[HttpPost("check-answers")]
        //public IActionResult CheckAnswers([FromBody] List<UserAnswer> userAnswers)
        //{
        //    int correctCount = 0;

        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        connection.Open();

        //        // Собираем все ID вопросов из ответа пользователя
        //        var ids = string.Join(",", userAnswers.ConvertAll(a => a.QuestionId));

        //        var query = $"SELECT Id, CorrectAnswer FROM dbo.PresentSimpleQuestions WHERE Id IN ({ids})";
        //        var command = new SqlCommand(query, connection);

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var correctAnswer = reader.GetInt32(1);
        //                var userAnswer = userAnswers.Find(a => a.QuestionId == reader.GetInt32(0));

        //                if (userAnswer != null && userAnswer.Answer == correctAnswer)
        //                {
        //                    correctCount++;
        //                }
        //            }
        //        }
        //    }

        //    return Ok(new { score = correctCount });
        //}
    }
}
