/* MIGHT NOT NEED THIS CONTROLLER AT ALL; MOVED ITS CRUD VIEWS OUTSIDE OF PROJECT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuantumLearn.Areas.Identity.Data;
using QuantumLearn.Models;

namespace QuantumLearn
{
    public class QuizResultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuizResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: QuizResult
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.QuizResult.Include(q => q.Answers).Include(q => q.Questions);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: QuizResult/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.QuizResult == null)
            {
                return NotFound();
            }

            var quizResult = await _context.QuizResult
                .Include(q => q.Answers)
                .Include(q => q.Questions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quizResult == null)
            {
                return NotFound();
            }

            return View(quizResult);
        }

        // GET: QuizResult/Create
        public IActionResult Create()
        {
            ViewData["AnswerId"] = new SelectList(_context.Set<Answer>(), "Id", "Id");
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id");
            return View();
        }

        // POST: QuizResult/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,QuestionId,AnswerId")] QuizResult quizResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quizResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnswerId"] = new SelectList(_context.Set<Answer>(), "Id", "Id", quizResult.AnswerId);
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", quizResult.QuestionId);
            return View(quizResult);
        }

        // GET: QuizResult/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.QuizResult == null)
            {
                return NotFound();
            }

            var quizResult = await _context.QuizResult.FindAsync(id);
            if (quizResult == null)
            {
                return NotFound();
            }
            ViewData["AnswerId"] = new SelectList(_context.Set<Answer>(), "Id", "Id", quizResult.AnswerId);
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", quizResult.QuestionId);
            return View(quizResult);
        }

        // POST: QuizResult/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,QuestionId,AnswerId")] QuizResult quizResult)
        {
            if (id != quizResult.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quizResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuizResultExists(quizResult.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnswerId"] = new SelectList(_context.Set<Answer>(), "Id", "Id", quizResult.AnswerId);
            ViewData["QuestionId"] = new SelectList(_context.Question, "Id", "Id", quizResult.QuestionId);
            return View(quizResult);
        }

        // GET: QuizResult/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.QuizResult == null)
            {
                return NotFound();
            }

            var quizResult = await _context.QuizResult
                .Include(q => q.Answers)
                .Include(q => q.Questions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quizResult == null)
            {
                return NotFound();
            }

            return View(quizResult);
        }

        // POST: QuizResult/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.QuizResult == null)
            {
                return Problem("Entity set 'ApplicationDbContext.QuizResult'  is null.");
            }
            var quizResult = await _context.QuizResult.FindAsync(id);
            if (quizResult != null)
            {
                _context.QuizResult.Remove(quizResult);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuizResultExists(int id)
        {
          return (_context.QuizResult?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
*/