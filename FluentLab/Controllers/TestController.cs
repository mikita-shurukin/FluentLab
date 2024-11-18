using FluentLab.Data;
using FluentLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluentLab.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult TakeTest(string testName)
        {
            var test = _context.Tests
                .Include(t => t.Questions)
                    .ThenInclude(q => q.Answers)
                .FirstOrDefault(t => t.Name == testName);

            if (test == null)
            {
                return NotFound();
            }

            foreach (var question in test.Questions)
            {
                question.Answers = question.Answers.OrderBy(a => Guid.NewGuid()).ToList(); // Перемешивание ответов
            }

            return View(test);
        }

        [HttpPost]
        public IActionResult SubmitTest(int testId, List<int> answers)
        {
            var test = _context.Tests
                .Include(t => t.Questions)
                    .ThenInclude(q => q.Answers)
                .FirstOrDefault(t => t.TestId == testId);

            if (test == null)
            {
                return NotFound();
            }

            int correctAnswers = 0;

            foreach (var question in test.Questions)
            {
                var correctAnswerIds = question.Answers
                    .Where(a => a.IsCorrect)
                    .Select(a => a.AnswerId)
                    .ToList();

                var userSelectedAnswers = answers.Where(a => question.Answers.Any(ans => ans.AnswerId == a)).ToList();

                if (userSelectedAnswers.Count == correctAnswerIds.Count &&
                    !userSelectedAnswers.Except(correctAnswerIds).Any())
                {
                    correctAnswers++;
                }
            }

            var percentage = (double)correctAnswers / test.Questions.Count * 100;

            return Json(new
            {
                correctAnswers = correctAnswers,
                totalQuestions = test.Questions.Count,
                percentage = percentage
            });
        }
    }
}
