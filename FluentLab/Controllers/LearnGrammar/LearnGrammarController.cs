using FluentLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace FluentLab.Controllers.LearnGrammar
{
    public class LearnGrammarController : Controller
    {

        public IActionResult PresentSimple()
        {
            return View();
        }

        public IActionResult FutureSimple()
        {
            return View();
        }
    }
}
