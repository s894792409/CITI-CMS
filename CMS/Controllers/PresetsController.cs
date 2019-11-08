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
    public class PresetsController : Controller
    {
        private readonly CMSContext _context;

        public PresetsController()
        {
            _context = new CMSContext();
        }

        // GET: Presets
        public async Task<IActionResult> Index()
        {
            ViewBag.rows = 5;
            return View(await _context.Preset.ToListAsync());
        }

       
        public ActionResult QueryTheme(int? id) {
            Preset preset = new Preset();
            preset.themeId = (int)id;
            TempData["model"] = preset;
            return RedirectToAction("Themes", "QueryTheme");
        }
        
            public IActionResult ViewTheme(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return Redirect("/Themes/ViewTheme?themeid="+id.ToString());
        }
        // GET: Presets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preset = await _context.Preset
                .SingleOrDefaultAsync(m => m.presetId == id);
            if (preset == null)
            {
                return NotFound();
            }

            return View(preset);
        }

        // GET: Presets/Create
        public IActionResult Create()
        {
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "VisitId", "Name");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View();
        }

        // POST: Presets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("presetId,themeId,visitId")] Preset preset)
        {
            if (ModelState.IsValid)
            {
                preset.dateCreated = DateTime.Now;
                _context.Add(preset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "VisitId", "Name");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View(preset);
        }

        // GET: Presets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preset = await _context.Preset.SingleOrDefaultAsync(m => m.presetId == id);
            if (preset == null)
            {
                return NotFound();
            }
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "VisitId", "Name");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View(preset);
        }

        // POST: Presets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("presetId,dateCreated,themeId,visitId")] Preset preset)
        {
            if (id != preset.presetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresetExists(preset.presetId))
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
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "VisitId", "Name");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View(preset);
        }

        // GET: Presets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preset = await _context.Preset
                .SingleOrDefaultAsync(m => m.presetId == id);
            if (preset == null)
            {
                return NotFound();
            }

            return View(preset);
        }

        // POST: Presets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preset = await _context.Preset.SingleOrDefaultAsync(m => m.presetId == id);
            var boxlist = await _context.Box.AsNoTracking().Where(s => s.presetId == preset.presetId).ToListAsync();
            foreach (Box box in boxlist)
            {
                try
                {
                    var cardlist = await _context.Card.AsNoTracking().Where(c => c.boxId == box.boxId).ToListAsync();
                    List<Card> cardRemovelist = new List<Card>();
                    foreach (Card card in cardlist)
                    {
                        cardRemovelist.Add(card);
                    }

                    try
                    {
                        for (int i = 0; i < cardRemovelist.Count(); i++)
                        {
                            _context.Card.Remove(cardRemovelist[i]);
                            await _context.SaveChangesAsync();
                        }

                    }
                    catch
                    {
                    }
                }
                catch (Exception e)
                {
                    return BadRequest();
                }

            }
            for (int i = 0; i < boxlist.Count(); i++)
            {
                _context.Box.Remove(boxlist[i]);
                await _context.SaveChangesAsync();
            }
            _context.Preset.Remove(preset);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool PresetExists(int id)
        {
            return _context.Preset.Any(e => e.presetId == id);
        }
    }
}
