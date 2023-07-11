using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using QuantumLearn.Models;
using QuantumLearn.Areas.Identity.Data;
using QuantumLearn.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Console.WriteLine("test 1");  // GET THIS
            Console.WriteLine($"Current user id (1st in SubmitQuiz action): {currentUserId}");  // GET THIS

            // ChatGPT code, I don't understand
            foreach (var question in _dbContext.Question)
            {
                int answerId;
                Console.WriteLine("test 2");  // GET THIS 7 TIMES

                // THIS IF STMT ISN'T CATCHING ANYTHING/NOT WORKING
                if (int.TryParse(form["answer_" + question.Id], out answerId))  
                {
                    var result = new QuizResult
                    {
                        UserId = currentUserId,
                        QuestionId = question.Id,
                        AnswerId = answerId
                    };
                    Console.WriteLine("test 3"); // DON'T GET THIS
                    _dbContext.QuizResult.Add(result);  // DOESN'T ADD ANYTHING TO DB
                    Console.WriteLine("test 4"); // DON'T GET THIS
                }
            }

            _dbContext.SaveChanges();
            Console.WriteLine("test 5");  // GET THIS 
            Console.WriteLine($"Current user id (2nd in SubmitQuiz action): {currentUserId}");  // GET THIS 

            return RedirectToAction("Results");
        }

        public IActionResult Results()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Console.WriteLine($"Current user id (Results action): {currentUserId}");  // GET THIS 

            // NOTHING IS BEING SAVED IN QUIZRESULT DB
            var results = _dbContext.QuizResult.Where(r => r.UserId == currentUserId)
                                                .Include(r => r.Questions)
                                                .Include(r => r.Answers)
                                                .ToList();

            int correctAnswers = results.Count(r => r.Answers.IsCorrect);

            ViewBag.CorrectAnswers = correctAnswers;
            ViewBag.TotalQuestions = results.Count;

            return View(results);
        }

        public IActionResult Quiz1()
        {
            // Quiz 1 Question 1 Answer 1-3
            Question? Q1Q1 = _dbContext.Question.FirstOrDefault(ques => ques.Id == 1); // lambda expression; ? so null can be a result
            Answer? Q1Q1A1 = _dbContext.Answer.FirstOrDefault(ans => ans.Id == 1);
            Answer? Q1Q1A2 = _dbContext.Answer.FirstOrDefault(ans => ans.Id == 2);
            Answer? Q1Q1A3 = _dbContext.Answer.FirstOrDefault(ans => ans.Id == 3);
            // Quiz 1 Question 2 Answer 1-3
            Question? Q1Q2 = _dbContext.Question.FirstOrDefault(ques => ques.Id == 2);
            Answer? Q1Q2A1 = _dbContext.Answer.FirstOrDefault(ans => ans.Id == 4);
            Answer? Q1Q2A2 = _dbContext.Answer.FirstOrDefault(ans => ans.Id == 5);
            Answer? Q1Q2A3 = _dbContext.Answer.FirstOrDefault(ans => ans.Id == 6);

            List<Question> _questions = new List<Question>();
            _questions.Add(Q1Q1);
            _questions.Add(Q1Q2);

            List<Answer> _answers = new List<Answer>();
            _answers.Add(Q1Q1A1);
            _answers.Add(Q1Q1A2);
            _answers.Add(Q1Q1A3);
            _answers.Add(Q1Q2A1);
            _answers.Add(Q1Q2A2);
            _answers.Add(Q1Q2A3);

            QuestionAnswerViewModel quesAnsVM = new QuestionAnswerViewModel()
            {
                QuestionList = _questions,
                AnswerList = _answers
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
