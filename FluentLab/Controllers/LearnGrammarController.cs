using Microsoft.AspNetCore.Mvc;

namespace FluentLab.Controllers
{
    public class LearnGrammarController : Controller
    {
        public IActionResult PresentSimple ()
        {
            return View();
        }
    }
}
