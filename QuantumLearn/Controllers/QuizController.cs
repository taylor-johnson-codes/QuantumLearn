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

            // the form from the frontend bring backs key-value pairs for each question; e.g. {[L1Q1, {3}]}
            // KEY - the name of the question group, e.g. brought back string value L1Q1 for the key from name="L1Q1" in the view
            // VALUE - a list of string values, e.g., {3} is a list with one value, the string 3 that came from selecting the third answer option on the frontend with value="3"

            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            foreach (var question in _dbContext.Question)  // BRINGS BACK ALL QUESTIONS FROM DB. ONLY NEED IT TO BRING BACK QUIZ 1 QUESTIONS, ADD THAT PROPERTY TO TABLE
            {
                int answerId;

                // the form sends back string values for integers, so convert string to int
                // ["L1Q" + question.Id] is creating L1Q1, L1Q2, etc.
                if (int.TryParse(form["L1Q" + question.Id], out answerId))  
                {
                    // if currentUserId && question.Id already exists in the DB, replace answerId with newest answerId submitted
                    // only want to create a new QuizResult entry if the user hasn't answered that question.Id yet, then results page will only show question/answer one time

                    var result = new QuizResult
                    {
                        UserId = currentUserId,
                        QuestionId = question.Id,
                        AnswerId = answerId,
                        //QuizNum = 1,2,3 etc
                    };
                    _dbContext.QuizResult.Add(result);
                }
            }

            _dbContext.SaveChanges();
            return RedirectToAction("Results");
        }

        public IActionResult Results(int passedQuizNum)  // SET UP REST OF CODE ABOVE TO PASS THIS VALUE
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var results = _dbContext.QuizResult.Where(r => r.UserId == currentUserId)
                                                .Include(r => r.Questions)
                                                .Include(r => r.Answers)
                                                //.Include(r => r.QuizNum.value == passedQuizNum)
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
