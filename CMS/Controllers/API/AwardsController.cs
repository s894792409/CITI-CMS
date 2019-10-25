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
    public class AwardsController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;


        public AwardsController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }

        // GET: api/Awards
        [HttpGet]
        public async Task<IEnumerable<Awards>> GetAwardsAsync()
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
                        return _context.Awards;
                    }
                }
            }
            catch {
                return null;
            }
            return null;
        }

        // GET: api/Awards/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAwards([FromRoute] int id)
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

                        var awards = await _context.Awards.FindAsync(id);

                        if (awards == null)
                        {
                            return NotFound();
                        }

                        return Ok(awards);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
          
        }

        // PUT: api/Awards/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAwards([FromRoute] int id, [FromBody] Awards awards)
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
                        var list = await _context.Awards.AsNoTracking().SingleAsync(s => s.awardId == id);
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
                }
            }
            catch
            {
                return null;
            }
            return null;

        
        }

        // POST: api/Awards
        [HttpPost]
        public async Task<IActionResult> PostAwards([FromBody] Awards awards)
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
                        awards.dateCreated = DateTime.Now;
                        _context.Awards.Add(awards);
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

        // DELETE: api/Awards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAwards([FromRoute] int id)
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
                }
            }
            catch
            {
                return null;
            }
            return null;
          
        }

        private bool AwardsExists(int id)
        {
            return _context.Awards.Any(e => e.awardId == id);
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