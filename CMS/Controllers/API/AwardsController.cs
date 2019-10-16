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
    public class AwardsController : ControllerBase
    {
        private readonly CMSContext _context;


        public AwardsController()
        {
            _context = new CMSContext();
        }

        // GET: api/Awards
        [HttpGet]
        public IEnumerable<Awards> GetAwards()
        {
            return _context.Awards;
        }

        // GET: api/Awards/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAwards([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var awards = await _context.Awards.FindAsync(id);

            if (awards == null)
            {
                return NotFound();
            }

            return Ok(awards);
        }

        // PUT: api/Awards/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAwards([FromRoute] int id, [FromBody] Awards awards)
        {

            if (!ModelState.IsValid)
            {
                APIReturn re4 = new APIReturn();
                re4.Status = "Failed";
                return BadRequest(re4);
            }

            if (id != awards.awardId)
            {
                APIReturn re2 = new APIReturn();
                re2.Status = "Failed";
                return BadRequest(re2);
            }

            //_context.Entry(awards).State = EntityState.Modified;
            var list = await _context.Awards.AsNoTracking().SingleAsync(s=>s.awardId==id);
            awards.awardId = id;
            try
            {
                _context.Update(awards);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AwardsExists(id))
                {
                    APIReturn re1 = new APIReturn();
                    re1.Status = "Failed";
                    return BadRequest(re1);
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

        // POST: api/Awards
        [HttpPost]
        public async Task<IActionResult> PostAwards([FromBody] Awards awards)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Awards.Add(awards);
            await _context.SaveChangesAsync();

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // DELETE: api/Awards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAwards([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var awards = await _context.Awards.FindAsync(id);
            if (awards == null)
            {
                return NotFound();
            }

            _context.Awards.Remove(awards);
            await _context.SaveChangesAsync();

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        private bool AwardsExists(int id)
        {
            return _context.Awards.Any(e => e.awardId == id);
        }
    }
}