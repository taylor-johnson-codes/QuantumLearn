using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using QuantumLearn.Models;
using QuantumLearn.Areas.Identity.Data;


namespace QuantumLearn.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Lesson");
        }

        public IActionResult Quiz1()
        {
            return View();
        }

        public IActionResult Quiz2()
        {
            return View();
        }

        public IActionResult Quiz3()
        {
            return View();
        }

        public IActionResult Quiz4()
        {
            return View();
        }

        public IActionResult Quiz5()
        {
            return View();
        }

        public IActionResult Quiz6()
        {
            return View();
        }

        public IActionResult Quiz7()
        {
            return View();
        }

        public IActionResult Quiz8()
        {
            return View();
        }

        public IActionResult Quiz9()
        {
            return View();
        }

        public IActionResult Quiz10()
        {
            return View();
        }

        public IActionResult Quiz11()
        {
            return View();
        }

        public IActionResult Quiz12()
        {
            return View();
        }

        public IActionResult Quiz13()
        {
            return View();
        }

        // ------------------------------------------------------------------------------------ //

        // All code below was copy/pasted from ChatGPT:
        /*
        private ApplicationDbContext _context;

        public QuizController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Quiz
        public ActionResult Index()
        {
            var questions = _context.Questions.Include(q => q.Answers).ToList();
            return View(questions);
        }

        [HttpPost]
        public ActionResult SubmitQuiz(IEnumerable<QuizResult> results)
        {
            string currentUserId = User.Identity.GetUserId();

            foreach (var result in results)
            {
                result.UserId = currentUserId;
                _context.QuizResults.Add(result);
            }

            _context.SaveChanges();

            return RedirectToAction("Results");
        }

        public ActionResult Results()
        {
            string currentUserId = User.Identity.GetUserId();
            var results = _context.QuizResults.Where(r => r.UserId == currentUserId).Include(r => r.Question).Include(r => r.Answer).ToList();
            return View(results);
        }
        */
    }
}
