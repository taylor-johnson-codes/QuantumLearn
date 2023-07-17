using Microsoft.AspNetCore.Mvc;
using QuantumLearn.Models;
using QuantumLearn.Areas.Identity.Data;
using QuantumLearn.ViewModels;
using System.Security.Claims;

namespace QuantumLearn.Controllers
{
    public class QuizController : Controller
    {
        // inject the Entity Framework database; inject the DbContext class in here
        private ApplicationDbContext _dbContext;
        public QuizController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Lesson");
        }

        public IActionResult SubmitQuiz(IFormCollection form) 
        {
            // NEED TO ADD IF USER IS LOGGED IN DO THE CODE BELOW, ELSE SHOW THE RESULTS TO NON-LOGGED IN USER

            // if ModelState is NOT valid, don't add, and return to view
            if (!ModelState.IsValid)
                return View();

            // if ModelState IS valid, add data to QuizResult table (if user is logged in), and return

            // the form from the frontend bring backs key-value pairs for each question; e.g. {[L1Q1, {3}]}
            // KEY - the name of the question group, e.g. brought back string value L1Q1 for the key from name="L1Q1" in the view
            // VALUE - a list of string values, e.g., {3} is a list with one value, the string 3 that came from selecting the third answer option on the frontend with value="3"

            foreach (var ques in _dbContext.Question.Where(ques => ques.QuizNum == 1))  
            {
                var result = new QuizResult
                {
                    UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    QuestionId = ques.Id,
                    // the form from the view is brought back to the controller as key-value pairs all in string format; example: {[L1Q1, {3}]}
                    // when the model field is coded as an int data type, the string needs to be converted to int
                    AnswerId = int.Parse(form["L1Q" + ques.Id]),  // the form group name is the key (L1Q1), and AnswerId will equal the value of the key-value pair (3)
                    QuizNum = int.Parse(form["formQuizNum"])  // formQuizNum is the key, 1 is the value; so QuizNum will equal 1
                };
                _dbContext.QuizResult.Add(result);
            }

            _dbContext.SaveChanges();
            return RedirectToAction("Results", new { passQuizNum = int.Parse(form["formQuizNum"]) });  
            // passing QuizNum value to the Results action (the second parameter has to be an object)
        }

        public IActionResult Results(int passQuizNum)
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Three lists to send to view
            List<Question> quesList = _dbContext.Question.Where(ques => ques.QuizNum == passQuizNum).ToList();
            List<Answer> ansList = _dbContext.Answer.Where(ans => ans.QuizNum == passQuizNum).ToList();
            List<QuizResult> resultsList = _dbContext.QuizResult.Where(res => res.UserId == currentUserId && res.QuizNum == passQuizNum).ToList();

            // Number of correct answer to send to view
            //int correctAnswers = ansList.Count(r => r.IsCorrect);
            //ViewBag.CorrectAnswers = correctAnswers;
            //ViewBag.TotalQuestions = quesList.Count;

            QuestionAnswerViewModel quesAnsVM = new QuestionAnswerViewModel()
            {
                QuestionList = quesList,
                AnswerList = ansList,
                QuizResultList = resultsList,
            };

            return View(quesAnsVM);
        }

        public IActionResult Quiz1()
        {
            // Two lists to send to view
            List<Question> quesList = _dbContext.Question.Where(ques => ques.QuizNum == 1).ToList();
            List<Answer> ansList = _dbContext.Answer.Where(ans => ans.QuizNum == 1).ToList();

            QuestionAnswerViewModel quesAnsVM = new QuestionAnswerViewModel()
            {
                QuestionList = quesList,
                AnswerList = ansList
            };

            return View(quesAnsVM);
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
    }
}
