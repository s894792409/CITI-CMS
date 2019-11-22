using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;
        public VisitsController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }

        // GET: api/Visits
        [HttpGet]
        public async Task<IEnumerable<Visits>> GetVisitsAsync()
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        try
                        {
                            DateTime start = Convert.ToDateTime(HttpContext.Request.Headers["startDate"].ToString());
                            DateTime end = Convert.ToDateTime(HttpContext.Request.Headers["endDate"].ToString());
                            if (start != null && end != null)
                            {
                                return _context.Visits.Where(s => s.StartDate > start && s.StartDate < end);
                            }
                        }
                        catch
                        {
                        }
                        string filter = HttpContext.Request.Headers["filter"];
                        
                        if (filter == "ThisWeek")
                        {
                            var today = DateTime.Today;
                            switch (today.DayOfWeek.ToString())
                            {
                                case "Monday":
                                    return  _context.Visits.Where(s => s.StartDate >= today.Date && s.StartDate <= today.AddDays(7).Date);
                                case "Tuesday":
                                    return _context.Visits.Where(s => s.StartDate >= today.AddDays(-1).Date && s.StartDate <= today.AddDays(6).Date);
                                case "Wednesday":
                                    return _context.Visits.Where(s => s.StartDate >= today.AddDays(-2).Date && s.StartDate <= today.AddDays(5).Date);
                                case "Thursday":
                                    return _context.Visits.Where(s => s.StartDate >= today.AddDays(-3).Date && s.StartDate <= today.AddDays(4).Date);
                                case "Friday":
                                    return _context.Visits.Where(s => s.StartDate >= today.AddDays(-4).Date && s.StartDate <= today.AddDays(3).Date);
                                case "Saturday":
                                    return _context.Visits.Where(s => s.StartDate >= today.AddDays(-5).Date && s.StartDate <= today.AddDays(2).Date);
                                case "Sunday":
                                    return _context.Visits.Where(s => s.StartDate >= today.AddDays(-6).Date && s.StartDate <= today.AddDays(1).Date);
                            }
                        }
                        if (filter == "ThisMonth") {
                            var today = DateTime.Today;
                            return _context.Visits.Where(s =>s.StartDate.Year==today.Year&&s.StartDate.Month==today.Month);
                        }
                        
                        return _context.Visits;
                    }
                }
                else {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // GET: api/Visits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisits([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
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
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // PUT: api/Visits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisits([FromRoute] int id, [FromBody] Visits visits)
        {
           
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
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
                            if (v.VisitId == id)
                            {
                                visits.VisitId = v.VisitId;
                                break;
                            }

                        }
                        try
                        {

                            visits.VisitId = id;
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
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // POST: api/Visits
        [HttpPost]
        public async Task<IActionResult> PostVisits([FromBody] Visits visits)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }
                        Visits visits1 = new Visits();
                        visits1.EndDate = visits.EndDate;
                        visits1.StartDate = visits.StartDate;
                        visits1.Pax = visits.Pax;
                        visits1.ForeignVisit = visits.ForeignVisit;
                        visits1.Host = visits.Host;
                        visits1.Name = visits.Name;
                        visits1.SIC = visits.SIC;
                        visits1.dateCreated = DateTime.Now;
                        _context.Visits.Add(visits1);
                        await _context.SaveChangesAsync();
                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        return Ok(re);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // DELETE: api/Visits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisits([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
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
                }
            }
            catch
            {
                return null;
            }
            return null;
           
        }

        private bool VisitsExists(int id)
        {
            return _context.Visits.Any(e => e.VisitId == id);
        }

        private static string MakeKey(int pwdLength)

        {     //声明要返回的字符串    

            string tmpstr = "";

            //密码中包含的字符数组    

            string pwdchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_?/-=";

            //数组索引随机数    

            int iRandNum;

            //随机数生成器    

            Random rnd = new Random();

            for (int i = 0; i < pwdLength; i++)

            {      //Random类的Next方法生成一个指定范围的随机数     

                iRandNum = rnd.Next(pwdchars.Length);

                //tmpstr随机添加一个字符     

                tmpstr += pwdchars[iRandNum];

            }

            return tmpstr;
        }

        public async Task RefreshAsync(UserInfo userInfo)
        {
            AppUser user = await userManager.FindByNameAsync(userInfo.UserName);
            user.UserKey = MakeKey(15);
            IdentityResult result2 = await userManager.UpdateAsync(user);
        }
    }
}