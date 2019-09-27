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
    public class VisitsController : ControllerBase
    {
        private readonly CMSContext _context;

        public VisitsController()
        {
            _context = new CMSContext();
        }

        // GET: api/Visits
        [HttpGet]
        public IEnumerable<Visits> GetVisits()
        {
            return _context.Visits;
        }

        // GET: api/Visits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisits([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var visits = await _context.Visits.FindAsync(id);

            if (visits == null)
            {
                return NotFound();
            }

            return Ok(visits);
        }

        // PUT: api/Visits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisits([FromRoute] int id, [FromBody] Visits visits)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (id != visits.visitId)
            //{
            //    return BadRequest();
            //}
            //_context.Entry(visits).State = EntityState.Modified;
            var list = await _context.Visits.AsNoTracking().ToListAsync();
            //list.Where(s => s.visitId == id);
            foreach (Visits v in list)
            {
                if (v.visitId == id)
                {
                    visits.dateCreated = v.dateCreated;
                    visits.visitDate = v.visitDate;
                    break;
                }

            }
            try
            {

                visits.visitId = id;
                //return Ok("开始更新" + visits.dateCreated + "   " + visits.GetType()+"  "+visits.visitId);
                _context.Update(visits);
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!VisitsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    return BadRequest(e.Message.ToString());
                }
            }

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // POST: api/Visits
        [HttpPost]
        public async Task<IActionResult> PostVisits([FromBody] Visits visits)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            visits.dateCreated = DateTime.Now;
            _context.Visits.Add(visits);
            await _context.SaveChangesAsync();
            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // DELETE: api/Visits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisits([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var visits = await _context.Visits.FindAsync(id);
            if (visits == null)
            {
                return NotFound();
            }

            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        private bool VisitsExists(int id)
        {
            return _context.Visits.Any(e => e.visitId == id);
        }
    }
}