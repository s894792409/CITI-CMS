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
    public class VisitsController : Controller
    {
        private readonly CMSContext _context;

        public VisitsController()
        {
            _context = new CMSContext();
        }

        // GET: Visits
        public async Task<IActionResult> Index()
        {
            var content = await _context.Visits.ToListAsync();
            return View(content);
        }

        // GET: Visits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visits
                .SingleOrDefaultAsync(m => m.visitId == id);
            if (visits == null)
            {
                return NotFound();
            }

            return View(visits);
        }

        // GET: Visits/Create
        public IActionResult Create()
        {
            var VisitTypelist = _context.VisitType.FromSql("SELECT visitTypeId, visitType FROM VisitType").ToList();
            var selectList = new SelectList(VisitTypelist, "visitTypeId", "visitType");
            ViewBag.visitTypes = selectList;
            var CompanyTypelist = _context.CompanyType.FromSql("SELECT companyTypeId, companyType FROM CompanyType").ToList();
            var companySelectList = new SelectList(CompanyTypelist, "companyTypeId", "companyType");
            ViewBag.CompanyType = companySelectList;
            return View();
        }
        

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("visitId,companyName,companyTypeId,noOfPax,visitDate,visitTypeId,dateCreated")] Visits visits)
        {
            if (ModelState.IsValid)
            {
                visits.dateCreated = DateTime.Now;
                _context.Add(visits);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var VisitTypelist = _context.VisitType.FromSql("SELECT visitTypeId, visitType FROM VisitType").ToList();
            var selectList = new SelectList(VisitTypelist, "visitTypeId", "visitType");
            ViewBag.visitTypes = selectList;
            var CompanyTypelist = _context.CompanyType.FromSql("SELECT companyTypeId, companyType FROM CompanyType").ToList();
            var companySelectList = new SelectList(CompanyTypelist, "companyTypeId", "companyType");
            ViewBag.CompanyType = companySelectList;
            return View(visits);
        }

        // GET: Visits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visits.SingleOrDefaultAsync(m => m.visitId == id);
            if (visits == null)
            {
                return NotFound();
            }
            var VisitTypelist = _context.VisitType.FromSql("SELECT visitTypeId, visitType FROM VisitType").ToList();
            var selectList = new SelectList(VisitTypelist, "visitTypeId", "visitType");
            ViewBag.visitTypes = selectList;
            var CompanyTypelist = _context.CompanyType.FromSql("SELECT companyTypeId, companyType FROM CompanyType").ToList();
            var companySelectList = new SelectList(CompanyTypelist, "companyTypeId", "companyType");
            ViewBag.CompanyType = companySelectList;
            return View(visits);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("visitId,companyName,companyTypeId,noOfPax,visitDate,visitTypeId")] Visits visits)
        {
            if (id != visits.visitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visits);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitsExists(visits.visitId))
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
            return View(visits);
        }

        // GET: Visits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visits
                .SingleOrDefaultAsync(m => m.visitId == id);
            if (visits == null)
            {
                return NotFound();
            }

            return View(visits);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visits = await _context.Visits.SingleOrDefaultAsync(m => m.visitId == id);
            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitsExists(int id)
        {
            return _context.Visits.Any(e => e.visitId == id);
        }
        public IActionResult QueryView()
        {
            return View();
        }

        public async Task<IActionResult> QueryVisit(Visits visits)
        {
            var visit = from m in _context.Visits
                          select m;

            if (!String.IsNullOrEmpty(visits.companyName))
            {
                visit = visit.Where(s => s.companyName.Contains(visits.companyName));
            }

            return View(await visit.ToListAsync());
        }
    }
}
