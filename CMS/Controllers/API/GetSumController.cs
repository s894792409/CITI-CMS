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
    public class GetSumController : ControllerBase
    {
        private readonly CMSContext context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;
        private Sum sum = new Sum();

        public GetSumController(UserManager<AppUser> userMgr)
        {
            context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
            int NoOfVisit = 0, NoOfProjects = 0, NoOfShortcourses = 0, NoOfAward = 0;
            var list = context.Visits.AsNoTracking().ToList();
            foreach (Visits visits in list)
            {
                NoOfVisit++;
            }
            var list2 =  context.Projects.AsNoTracking().ToList();
            foreach (Projects visits in list2)
            {
                NoOfProjects++;
            }
            var list3 =  context.ShortCourses.AsNoTracking().ToList();
            foreach (ShortCourses visits in list3)
            {
                NoOfShortcourses++;
            }
            var list4 =  context.Awards.AsNoTracking().ToList();
            foreach (Awards visits in list4)
            {
                NoOfAward++;
            }

            sum.AwardsSum = NoOfAward;
            sum.ShortCoursesSum = NoOfShortcourses;
            sum.ProjectsSum = NoOfProjects;
            sum.VisitsSum = NoOfVisit;
        }
        // GET: api/GetSum
        [HttpGet]
        public async Task<IActionResult> GetAsync()
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
                        return Ok(sum);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // GET: api/GetSum/VisitsSum
        [HttpGet("{name}", Name = "Get")]
        public async Task<IActionResult> GetAsync(string name)
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
                        if (name == "VisitsSum")
                        {
                            VisitSum visitSum = new VisitSum();
                            visitSum.VisitsSum = sum.VisitsSum;
                            return Ok(visitSum);
                        }
                        else if (name == "ProjectsSum")
                        {
                            ProjectSum projectSum = new ProjectSum();
                            projectSum.ProjectsSum = sum.ProjectsSum;
                            return Ok(projectSum);
                        }
                        else if (name == "ShortCoursesSum")
                        {
                            ShortCoursSum shortCoursSum = new ShortCoursSum();
                            shortCoursSum.ShortCoursesSum = sum.ShortCoursesSum;
                            return Ok(shortCoursSum);
                        }
                        else if (name == "AwardsSum")
                        {
                            AwardSum awardSum = new AwardSum();
                            awardSum.AwardsSum = sum.AwardsSum;
                            return Ok(awardSum);
                        }
                        return BadRequest();
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
           
        }
        public class AwardSum {
            public int AwardsSum { get; set; }
        }
        public class ShortCoursSum
        {
            public int ShortCoursesSum { get; set; }
        }
        public class ProjectSum
        {
            public int ProjectsSum { get; set; }
        }
        public class VisitSum
        {
            public int VisitsSum { get; set; }
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
