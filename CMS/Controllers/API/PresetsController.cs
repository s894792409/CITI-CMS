using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresetsController : ControllerBase
    {
        private readonly CMSContext _context;

        public PresetsController()
        {
            _context = new CMSContext();
        }

        // GET: api/Presets
        [HttpGet]
        public IEnumerable<Preset> GetPreset()
        {
            return _context.Preset;
        }

        // GET: api/Presets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreset([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var preset = await _context.Preset.FindAsync(id);

            if (preset == null)
            {
                return NotFound();
            }

            return Ok(preset);
        }

        // PUT: api/Presets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreset([FromRoute] int id, [FromBody] Preset preset)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != preset.presetId)
            {
                return BadRequest();
            }

            // _context.Entry(preset).State = EntityState.Modified;
            var list = await _context.Preset.AsNoTracking().SingleAsync(s => s.presetId == id);
            preset.presetId = id;

            try
            {
                _context.Update(preset);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PresetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // POST: api/Presets
        [HttpPost]
        public async Task<IActionResult> PostPreset([FromBody] Preset preset)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            preset.dateCreated = DateTime.Now;
            _context.Preset.Add(preset);
            await _context.SaveChangesAsync();

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // DELETE: api/Presets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreset([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var preset = await _context.Preset.FindAsync(id);
            if (preset == null)
            {
                return NotFound();
            }

            _context.Preset.Remove(preset);
            await _context.SaveChangesAsync();

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        private bool PresetExists(int id)
        {
            return _context.Preset.Any(e => e.presetId == id);
        }
    }
}