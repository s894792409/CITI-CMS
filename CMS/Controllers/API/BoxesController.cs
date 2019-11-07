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
    public class BoxesController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;

        public BoxesController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }
        // DELETE: api/Boxes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBox([FromRoute] int id)
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
                        try
                        {
                            var box = await _context.Box.AsNoTracking().SingleAsync(s => s.boxId == id);
                            try
                            {
                                var cardlist = await _context.Card.AsNoTracking().Where(c => c.boxId == box.boxId).ToListAsync();
                                for (int i = 0; i < cardlist.Count(); i++)
                                {
                                    _context.Card.Remove(cardlist[i]);
                                    await _context.SaveChangesAsync();
                                }
                            }
                            catch { }
                            _context.Box.Remove(box);
                            await _context.SaveChangesAsync();
                            string succass = "succass";
                            return new JsonResult(new { succass = succass });
                        }
                        catch
                        {
                            return NotFound();
                        }
                    }
                }
            }
            catch
            {
                return BadRequest();
            }

            return BadRequest();
        }

        private bool BoxExists(int id)
        {
            return _context.Box.Any(e => e.boxId == id);
        }
        public async Task RefreshAsync(UserInfo userInfo)
        {
            AppUser user = await userManager.FindByNameAsync(userInfo.UserName);
            user.UserKey = MakeKey(15);
            IdentityResult result2 = await userManager.UpdateAsync(user);
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
    }
}