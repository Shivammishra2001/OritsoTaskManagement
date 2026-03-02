using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OritsoTaskManagement.Data;
using OritsoTaskManagement.Models;

namespace OritsoTaskManagement.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ================= READ =================
        public async Task<IActionResult> Index(string searchString)
        {
            var tasks = from t in _context.Tasks
                        select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                tasks = tasks.Where(s =>
                    s.Title.Contains(searchString) ||
                    s.Status.Contains(searchString));
            }

            return View(await tasks.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var task = await _context.Tasks.FirstOrDefaultAsync(m => m.Id == id);
            if (task == null) return NotFound();

            return View(task);
        }

        // ================= CREATE =================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                task.CreatedOn = DateTime.Now;
                task.CreatedByName = "Admin";
                task.CreatedById = 1;

                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }
        // ================= UPDATE =================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TaskItem task)
        {
            if (id != task.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    task.UpdatedOn = DateTime.Now;
                    task.UpdatedByName = "Admin";
                    task.UpdatedById = 1;

                    _context.Update(task);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Tasks.Any(e => e.Id == task.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
                return NotFound();

            return View(task);
        }
        // ================= DELETE =================
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var task = await _context.Tasks
                .FirstOrDefaultAsync(m => m.Id == id);

            if (task == null) return NotFound();

            return View(task);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}