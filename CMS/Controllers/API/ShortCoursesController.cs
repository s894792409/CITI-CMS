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
    public class ShortCoursesController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;
        public ShortCoursesController(UserManager<AppUser> userMgr)
        {
            userManager = userMgr;
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
        }

        // GET: api/ShortCourses
        [HttpGet]
        public async Task<IEnumerable<ShortCourses>> GetShortCourses()
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
                        return _context.ShortCourses;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // GET: api/ShortCourses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShortCourses([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        var shortCourses = await _context.ShortCourses.FindAsync(id);

                        if (shortCourses == null)
                        {
                            return NotFound();
                        }
                        await RefreshAsync(userInfo);
                        return Ok(shortCourses);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // PUT: api/ShortCourses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShortCourses([FromRoute] int id, [FromBody] ShortCourses shortCourses)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        if (id != shortCourses.courseId)
                        {
                            return BadRequest();
                        }

                        // _context.Entry(shortCourses).State = EntityState.Modified;
                        var list = await _context.ShortCourses.AsNoTracking().SingleAsync(s => s.courseId == id);
                        shortCourses.courseId = id;

                        try
                        {
                            _context.Update(shortCourses);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!ShortCoursesExists(id))
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
                        await RefreshAsync(userInfo);
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

        // POST: api/ShortCourses
        [HttpPost]
        public async Task<IActionResult> PostShortCourses([FromBody] ShortCourses shortCourses)
        {
           
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }
                        shortCourses.dateCreated = DateTime.Now;
                        _context.ShortCourses.Add(shortCourses);
                        await _context.SaveChangesAsync();

                        //return CreatedAtAction("GetShortCourses", new { id = shortCourses.courseId }, shortCourses);
                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        await RefreshAsync(userInfo);
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

        // DELETE: api/ShortCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShortCourses([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        var shortCourses = await _context.ShortCourses.FindAsync(id);
                        if (shortCourses == null)
                        {
                            return NotFound();
                        }

                        _context.ShortCourses.Remove(shortCourses);
                        await _context.SaveChangesAsync();

                        // return Ok(shortCourses);
                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        await RefreshAsync(userInfo);
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

        private bool ShortCoursesExists(int id)
        {
            return _context.ShortCourses.Any(e => e.courseId == id);
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