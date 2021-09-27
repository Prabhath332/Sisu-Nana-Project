using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using web_project.Data;
using web_project.Models;

namespace web_project.Controllers
{
    public class RegistedStudentsController : Controller
    {
        private readonly web_projectContext _context;

        public RegistedStudentsController(web_projectContext context)
        {
            _context = context;
        }

        // GET: RegistedStudents
        public async Task<IActionResult> Index()
        {
            var web_projectContext = _context.RegistedStudent.Include(r => r.Class).Include(r => r.User);
            return View(await web_projectContext.ToListAsync());
        }

        // GET: RegistedStudents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registedStudent = await _context.RegistedStudent
                .Include(r => r.Class)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registedStudent == null)
            {
                return NotFound();
            }

            return View(registedStudent);
        }

        // GET: RegistedStudents/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "FirstName");
            return View();
        }

        // POST: RegistedStudents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassId,UserId")] RegistedStudent registedStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registedStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id", registedStudent.ClassCode);
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "FirstName", registedStudent.UserId);
            return View(registedStudent);
        }

        // GET: RegistedStudents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registedStudent = await _context.RegistedStudent.FindAsync(id);
            if (registedStudent == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id", registedStudent.ClassCode);
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "FirstName", registedStudent.UserId);
            return View(registedStudent);
        }

        // POST: RegistedStudents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassId,UserId")] RegistedStudent registedStudent)
        {
            if (id != registedStudent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registedStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistedStudentExists(registedStudent.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "Id", registedStudent.ClassCode);
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "FirstName", registedStudent.UserId);
            return View(registedStudent);
        }

        // GET: RegistedStudents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registedStudent = await _context.RegistedStudent
                .Include(r => r.Class)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registedStudent == null)
            {
                return NotFound();
            }

            return View(registedStudent);
        }

        // POST: RegistedStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registedStudent = await _context.RegistedStudent.FindAsync(id);
            _context.RegistedStudent.Remove(registedStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistedStudentExists(int id)
        {
            return _context.RegistedStudent.Any(e => e.Id == id);
        }
    }
}
