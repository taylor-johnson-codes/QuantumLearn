using Microsoft.AspNetCore.Mvc;
using QuantumLearn.ViewModels;

namespace QuantumLearn.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Num1()
        {
            // Info to send to view via the ViewModel
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 1
            };

            return View(lessonNumVM);
        }

        public IActionResult Num2()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 2
            };

            return View(lessonNumVM);
        }

        public IActionResult Num3()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 3
            };

            return View(lessonNumVM);
        }

        public IActionResult Num4()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 4
            };

            return View(lessonNumVM);
        }

        public IActionResult Num5()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 5
            };

            return View(lessonNumVM);
        }

        public IActionResult Num6()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 6
            };

            return View(lessonNumVM);
        }

        public IActionResult Num7()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 7
            };

            return View(lessonNumVM);
        }

        public IActionResult Num8()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 8
            };

            return View(lessonNumVM);
        }

        public IActionResult Num9()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 9
            };

            return View(lessonNumVM);
        }

        public IActionResult Num10()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 10
            };

            return View(lessonNumVM);
        }

        public IActionResult Num11()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 11
            };

            return View(lessonNumVM);
        }

        public IActionResult Num12()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 12
            };

            return View(lessonNumVM);
        }

        public IActionResult Num13()
        {
            LessonNumViewModel lessonNumVM = new LessonNumViewModel()
            {
                QuizNum = 13
            };

            return View(lessonNumVM);
        }
    }
}
