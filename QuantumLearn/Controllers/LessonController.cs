using Microsoft.AspNetCore.Mvc;

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
            // Info to send to view
            int lessonNum = 1;
            return View(lessonNum);
        }

        public IActionResult Num2()
        {
            int lessonNum = 2;
            return View(lessonNum);
        }

        public IActionResult Num3()
        {
            int lessonNum = 3;
            return View(lessonNum);
        }

        public IActionResult Num4()
        {
            int lessonNum = 4;
            return View(lessonNum);
        }

        public IActionResult Num5()
        {
            int lessonNum = 5;
            return View(lessonNum);
        }

        public IActionResult Num6()
        {
            int lessonNum = 6;
            return View(lessonNum);
        }

        public IActionResult Num7()
        {
            int lessonNum = 7;
            return View(lessonNum);
        }

        public IActionResult Num8()
        {
            int lessonNum = 8;
            return View(lessonNum);
        }

        public IActionResult Num9()
        {
            int lessonNum = 9;
            return View(lessonNum);
        }

        public IActionResult Num10()
        {
            int lessonNum = 10;
            return View(lessonNum);
        }

        public IActionResult Num11()
        {
            int lessonNum = 11;
            return View(lessonNum);
        }

        public IActionResult Num12()
        {
            int lessonNum = 12;
            return View(lessonNum);
        }

        public IActionResult Num13()
        {
            int lessonNum = 13;
            return View(lessonNum);
        }
    }
}
