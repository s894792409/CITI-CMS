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
    public class AwardsController : Controller
    {
        private readonly CMSContext _context;

        public AwardsController()
        {
            _context = new CMSContext();
        }

        // GET: Awards
        public async Task<IActionResult> Index()
        {
            return View(await _context.Awards.ToListAsync());
        }

        // GET: Awards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var awards = await _context.Awards
                .SingleOrDefaultAsync(m => m.awardId == id);
            if (awards == null)
            {
                return NotFound();
            }

            return View(awards);
        }

        // GET: Awards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Awards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("awardId,awardName,awardLevel,noOfRecipients,awardType")] Awards awards)
        {
            if (ModelState.IsValid)
            {
                _context.Add(awards);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(awards);
        }

        // GET: Awards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var awards = await _context.Awards.SingleOrDefaultAsync(m => m.awardId == id);
            if (awards == null)
            {
                return NotFound();
            }
            return View(awards);
        }
        public IActionResult QueryView()
        {
            return View();
        }
        public async Task<IActionResult> QueryAwards(Awards awards)
        {
            var list = from m in _context.Awards
                       select m;

            if (!String.IsNullOrEmpty(awards.awardName))
            {
                list = list.Where(s => s.awardName.Contains(awards.awardName));
            }

            return View(await list.ToListAsync());
        }
        // POST: Awards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("awardId,awardName,awardLevel,noOfRecipients,awardType,dateCreated")] Awards awards)
        {
            if (id != awards.awardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(awards);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AwardsExists(awards.awardId))
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
            return View(awards);
        }

        // GET: Awards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var awards = await _context.Awards
                .SingleOrDefaultAsync(m => m.awardId == id);
            if (awards == null)
            {
                return NotFound();
            }

            return View(awards);
        }

        // POST: Awards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var awards = await _context.Awards.SingleOrDefaultAsync(m => m.awardId == id);
            _context.Awards.Remove(awards);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AwardsExists(int id)
        {
            return _context.Awards.Any(e => e.awardId == id);
        }
    }
}
