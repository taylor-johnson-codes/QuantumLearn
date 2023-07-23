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
            if (!ModelState.IsValid)  // if ModelState is NOT valid, go to error page
                return View("Shared/Error");  // NEED TO TEST THIS

            // if ModelState IS valid, add data to the QuizResult table and display Results view

            string? currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            int currentQuizNum = int.Parse(form["formQuizNum"]);    // the form from the view is brought back to the controller as key-value pairs all in string format; example: {[L1Q1, {3}]}
                                                                    // formQuizNum is the key; the value is the quiz number the form is from
                                                                    // when the model field is coded as an int data type, the string needs to be converted to int
                                                                    // for error handling, upgrade int.Parse() to TryParse() or Try {}Catch{}

            if (currentUserId != null)  // if the user IS logged in
            {
                foreach (var ques in _dbContext.Question.Where(ques => ques.QuizNum == currentQuizNum))
                {
                    int currentAnsId = int.Parse(form[$"L{currentQuizNum}Q{ques.Id}"]);  // the form group name is the key (e.g. L1Q1), and currentAnsId will equal the value of the key-value pair (e.g. 3)

                    // check the database for an existing entry
                    QuizResult? entry = _dbContext.QuizResult.Where(res => res.UserId == currentUserId && res.QuestionId == ques.Id).FirstOrDefault();

                    if (entry != null)  // if an entry already exists, update it with the newly submitted answer
                    {
                        entry.AnswerId = currentAnsId;
                    }
                    else  // otherwise, create a new entry
                    {
                        QuizResult result = new QuizResult
                        {
                            UserId = currentUserId,
                            QuestionId = ques.Id,
                            AnswerId = currentAnsId,
                            QuizNum = currentQuizNum
                        };
                        _dbContext.QuizResult.Add(result);
                    }
                }
                _dbContext.SaveChanges();
                return RedirectToAction("Results", new { passQuizNum = currentQuizNum });  // passing QuizNum value to the Results action (the second parameter has to be an object)
            }
            else  // if the user is NOT logged in
            {
                // using ViewBag to send a list of results to the view for displaying since these results aren't being stored in the database

                List<QuizResult> resultsList = new List<QuizResult>();

                foreach (var ques in _dbContext.Question.Where(ques => ques.QuizNum == currentQuizNum))
                {
                    int currentAnsId = int.Parse(form[$"L{currentQuizNum}Q{ques.Id}"]);  // the form group name is the key (e.g. L1Q1), and currentAnsId will equal the value of the key-value pair (e.g. 3)

                    QuizResult result = new QuizResult
                    {
                        UserId = null,
                        QuestionId = ques.Id,
                        AnswerId = currentAnsId,
                        QuizNum = currentQuizNum
                    };
                    resultsList.Add(result);
                }

                ViewBag.ResultsList = resultsList;

                // Info to to send to view
                int quizNum = currentQuizNum;
                List<Question> quesList = _dbContext.Question.Where(ques => ques.QuizNum == currentQuizNum).ToList();
                List<Answer> ansList = _dbContext.Answer.Where(ans => ans.QuizNum == currentQuizNum).ToList();

                QuestionAnswerViewModel quesAnsVM = new QuestionAnswerViewModel()
                {
                    QuizNum = currentQuizNum,
                    QuestionList = quesList,
                    AnswerList = ansList,
                };

                return View(quesAnsVM);
            }
        }

        public IActionResult Results(int passQuizNum)
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Info to to send to view
            int quizNum = passQuizNum;
            List<Question> quesList = _dbContext.Question.Where(ques => ques.QuizNum == passQuizNum).ToList();
            List<Answer> ansList = _dbContext.Answer.Where(ans => ans.QuizNum == passQuizNum).ToList();
            List<QuizResult> resultsList = _dbContext.QuizResult.Where(res => res.UserId == currentUserId && res.QuizNum == passQuizNum).ToList();

            QuestionAnswerViewModel quesAnsVM = new QuestionAnswerViewModel()
            {
                QuizNum = passQuizNum,
                QuestionList = quesList,
                AnswerList = ansList,
                QuizResultList = resultsList
            };

            return View(quesAnsVM);
        }

        public IActionResult QuizContent(int passedQuizNum)
        {
            // Info to send to view via the ViewModel
            int quizNum = passedQuizNum;
            List<Question> quesList = _dbContext.Question.Where(ques => ques.QuizNum == quizNum).ToList();
            List<Answer> ansList = _dbContext.Answer.Where(ans => ans.QuizNum == quizNum).ToList();

            QuestionAnswerViewModel quesAnsVM = new QuestionAnswerViewModel()
            {
                QuizNum = quizNum,
                QuestionList = quesList,
                AnswerList = ansList
            };

            return View("Quiz", quesAnsVM);
        }

        public IActionResult Quiz1()
        {
            int quizNum = 1;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });  // passing QuizNum value to the QuizContent action (the second parameter has to be an object)
        }

        public IActionResult Quiz2()
        {
            int quizNum = 2;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz3()
        {
            int quizNum = 3;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz4()
        {
            int quizNum = 4;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz5()
        {
            int quizNum = 5;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz6()
        {
            int quizNum = 6;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz7()
        {
            int quizNum = 7;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz8()
        {
            int quizNum = 8;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz9()
        {
            int quizNum = 9;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz10()
        {
            int quizNum = 10;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz11()
        {
            int quizNum = 11;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz12()
        {
            int quizNum = 12;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }

        public IActionResult Quiz13()
        {
            int quizNum = 13;
            return RedirectToAction("QuizContent", new { passedQuizNum = quizNum });
        }
    }
}
