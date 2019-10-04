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
    public class VisitTypesController : Controller
    {
        private readonly CMSContext _context;

        public VisitTypesController()
        {
            _context = new CMSContext();
        }

        // GET: VisitTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VisitType.ToListAsync());
        }

        // GET: VisitTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitType = await _context.VisitType
                .SingleOrDefaultAsync(m => m.visitTypeId == id);
            if (visitType == null)
            {
                return NotFound();
            }

            return View(visitType);
        }

        // GET: VisitTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VisitTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( VisitType visitType2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitType2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visitType2);
        }

        // GET: VisitTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitType = await _context.VisitType.SingleOrDefaultAsync(m => m.visitTypeId == id);
            if (visitType == null)
            {
                return NotFound();
            }
            return View(visitType);
        }

        // POST: VisitTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("visitTypeId,visitType")] VisitType visitType1)
        {
            if (id != visitType1.visitTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitType1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitTypeExists(visitType1.visitTypeId))
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
            return View(visitType1);
        }

        // GET: VisitTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitType = await _context.VisitType
                .SingleOrDefaultAsync(m => m.visitTypeId == id);
            if (visitType == null)
            {
                return NotFound();
            }

            return View(visitType);
        }

        // POST: VisitTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id,string visitType)
        {
            var Visitlist = await _context.Visits.ToListAsync();

            foreach (Visits visits in Visitlist)
            {
                if (visits.visitTypeId == id)
                {
                    ViewBag.error = "This item is currently being used";
                    VisitType type = new VisitType();
                    type.visitType = visitType;
                    type.visitTypeId = id;
                    return View(type);
                }
            }
            var visitType1 = await _context.VisitType.SingleOrDefaultAsync(m => m.visitTypeId == id);
            _context.VisitType.Remove(visitType1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitTypeExists(int id)
        {
            return _context.VisitType.Any(e => e.visitTypeId == id);
        }
    }
}
