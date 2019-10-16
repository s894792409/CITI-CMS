using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CMS.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly CMSContext _context;

        public StudentsController()
        {
            _context = new CMSContext();
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }
        public IActionResult QueryView()
        {
            return View();
        }
        public async Task<IActionResult> QueryStudent(Student student)
        {
            var list = from m in _context.Student
                        select m;

            if (!String.IsNullOrEmpty(student.studentName))
            {
                list = list.Where(s => s.studentName.Contains(student.studentName));
            }

            return View(await list.ToListAsync());
        }
        // GET: Students/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .SingleOrDefaultAsync(m => m.studentAdmin == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            var projectlist = _context.Projects.ToList();
            var projectSelect = new SelectList(projectlist, "projectId", "projectName");
            ViewBag.projectselect = projectSelect;
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("studentAdmin,studentName,projectId,studentYear")] Student student)
        {
            if (ModelState.IsValid)
            {
                //var project = await _context.Projects.SingleOrDefaultAsync(m => m.projectId == student.projectId);
                //        project.noOfStudents += 1;
                //        _context.Update(project);
                //        await _context.SaveChangesAsync();
                var check = await _context.Student.SingleOrDefaultAsync(s => s.studentAdmin == student.studentAdmin);
                if (check == null)
                {
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else {
                    ViewBag.error = "The student Admin already exists!";
                    var projectlist = _context.Projects.ToList();
                    var projectSelect = new SelectList(projectlist, "projectId", "projectName");
                    ViewBag.projectselect = projectSelect;
                    return View();
                }
                
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.SingleOrDefaultAsync(m => m.studentAdmin == id);
            if (student == null)
            {
                return NotFound();
            }
            var projectlist = _context.Projects.ToList();
            var projectSelect = new SelectList(projectlist, "projectId", "projectName");
            ViewBag.projectselect = projectSelect;
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("studentAdmin,studentName,projectId,studentYear,dateCreated")] Student student)
        {
            if (id != student.studentAdmin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.studentAdmin))
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
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .SingleOrDefaultAsync(m => m.studentAdmin == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var student = await _context.Student.SingleOrDefaultAsync(m => m.studentAdmin == id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.studentAdmin == id);
        }
    }
}
