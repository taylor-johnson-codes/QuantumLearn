using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using QuantumLearn.Models;
using QuantumLearn.Areas.Identity.Data;
using QuantumLearn.ViewModels;

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
