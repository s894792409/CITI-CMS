using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;

namespace CMS.Controllers
{
    public class ShortCoursesController : Controller
    {
        private readonly CMSContext _context;

        public ShortCoursesController()
        {
            _context = new CMSContext();
        }

        // GET: ShortCourses
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShortCourses.ToListAsync());
        }

        // GET: ShortCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortCourses = await _context.ShortCourses
                .SingleOrDefaultAsync(m => m.courseId == id);
            if (shortCourses == null)
            {
                return NotFound();
            }

            return View(shortCourses);
        }

        // GET: ShortCourses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShortCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("courseId,courseName,courseSubject,courseInstructor,courseVenue")] ShortCourses shortCourses)
        {

            if (ModelState.IsValid)
            {
                shortCourses.dateCreated = DateTime.Now;
                _context.Add(shortCourses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shortCourses);
        }

        // GET: ShortCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortCourses = await _context.ShortCourses.SingleOrDefaultAsync(m => m.courseId == id);
            if (shortCourses == null)
            {
                return NotFound();
            }
            return View(shortCourses);
        }

        // POST: ShortCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("courseId,courseName,courseSubject,courseInstructor,courseVenue,dateCreated")] ShortCourses shortCourses)
        {
            if (id != shortCourses.courseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shortCourses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShortCoursesExists(shortCourses.courseId))
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
            return View(shortCourses);
        }

        // GET: ShortCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortCourses = await _context.ShortCourses
                .SingleOrDefaultAsync(m => m.courseId == id);
            if (shortCourses == null)
            {
                return NotFound();
            }

            return View(shortCourses);
        }

        // POST: ShortCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shortCourses = await _context.ShortCourses.SingleOrDefaultAsync(m => m.courseId == id);
            _context.ShortCourses.Remove(shortCourses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShortCoursesExists(int id)
        {
            return _context.ShortCourses.Any(e => e.courseId == id);
        }
    }
}
