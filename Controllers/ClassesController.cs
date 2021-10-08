using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using web_project.Data;
using web_project.Models;

namespace web_project.Controllers
{
    public class ClassesController : Controller
    {
        private readonly web_projectContext _context;

        public ClassesController(web_projectContext context)
        {
            _context = context;
        }

        // GET: Classes
        public async Task<IActionResult> Index()
        {
            var web_projectContext = _context.Class;
            return View(await web_projectContext.ToListAsync());
        }
        public async Task<IActionResult> Materials()
        {
          
            return View();
        }
        public async Task<IActionResult> Classes()
        {
            var web_projectContext = _context.Class;
            return View(await web_projectContext.ToListAsync());
        }

        // GET: Classes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.Class
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // GET: Classes/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "FirstName");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToClass([Bind("Id,Advertiesment,UserId,Grade,Subject,Date,Time")] Class @class)
        {
            if (ModelState.IsValid)
            {
                RegistedStudent registedStudent = new RegistedStudent();
                registedStudent.ClassId = @class.Id;               
                var user = _context.User.Where(a => a.UserName == this.User.Identity.Name);
                registedStudent.UserId = user.FirstOrDefault().Id;        
                _context.Add(registedStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Classes));
            }
            return View(@class);
        }

        // POST: Classes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Advertiesment,Url,UserId,Grade,Subject,Date,Time")] Class @class)
        {
            if (ModelState.IsValid)
            {
               @class.Teacher = this.User.Identity.Name;
                var img = this.UploadedFile(@class.Advertiesment);
                @class.Image = img;
                _context.Add(@class);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@class);
        }

        public async Task<IActionResult> Register([Bind("Id,Advertiesment,Url,UserId,Grade,Subject,Date,Time")] Class @class)
        {
            if (ModelState.IsValid)
            {
                RegistedStudent registedStudent = new RegistedStudent();
                _context.Add(registedStudent);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@class);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.Class.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }
            return View(@class);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Advertiesment,UserId,Grade,Subject,Date,Time,Image")] Class @class)
        {
            if (id != @class.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(@class.Advertiesment !=null)
                    {
                        var img = this.UploadedFile(@class.Advertiesment);
                        @class.Image = img;
                    }
                   
                    _context.Update(@class);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassExists(@class.Id))
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
            return View(@class);
        }

        // GET: Classes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.Class
               
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @class = await _context.Class.FindAsync(id);
            _context.Class.Remove(@class);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassExists(int id)
        {
            return _context.Class.Any(e => e.Id == id);
        }

        private string UploadedFile(IFormFile File)
        {
            string uniqueFileName = null;

            if (File != null)
            {

                string path = AppManage.requestimagePath;
                try
                {

                    if (Directory.Exists(path))
                    {

                    }
                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
                uniqueFileName = Guid.NewGuid().ToString().Split("-").ElementAt(0) + "_" + File.FileName;

                string filePath = Path.Combine(AppManage.requestimagePath, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    File.CopyTo(fileStream);
                }
            }
            return @"images\" + uniqueFileName;
        }
    }
}
