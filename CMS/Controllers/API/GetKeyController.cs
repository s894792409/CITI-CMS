using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetKeyController : ControllerBase
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private RoleManager<IdentityRole> roleManager;

        public GetKeyController(UserManager<AppUser> userMgr, SignInManager<AppUser> signinMgr, RoleManager<IdentityRole> roleMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
            roleManager = roleMgr;
        }

        // POST: api/GetKey
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] ApiLogin login)
        {
            AppUser user = await userManager.FindByNameAsync(login.UserName);
            if (user != null)
            {
                await signInManager.SignOutAsync();
                Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, login.Password, false, false);

                if (result.Succeeded)
                {
                    string info = HttpContext.Request.Headers["action"];
                    if (info == "GetKey")
                    {
                        Success respone = new Success();
                        respone.Key = user.UserKey;
                        return Ok(respone);
                    }
                    //else if (info == "RefreshKey") {
                    //    user.UserKey = MakeKey(15);
                    //    IdentityResult result2 = await userManager.UpdateAsync(user);
                    //    if (result2.Succeeded)
                    //    {
                    //        Success respone = new Success();
                    //        respone.Key = user.UserKey;
                    //        return Ok(respone);
                    //    }
                    //    else {
                    //        Failure failure2 = new Failure();
                    //        failure2.failure = "failure";
                    //        return Ok(failure2);
                    //    }
                           
                    //}
                }
            }
            Failure failure = new Failure();
            failure.failure = "failure";
            return Ok(failure);
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
        //[HttpGet]
        //public IActionResult KeyTest()
        //{

        //    //获取请求头信息
        //    string info = HttpContext.Request.Headers["Key"];

        //    //返回响应结果
        //    HttpResponseMessage result = new HttpResponseMessage();
        //    result.Content = new StringContent("请求头信息为：" + info);

        //    //添加响应头信息
        //    result.Headers.Add("Access-Control-Expose-Headers", "My-Headers-Info");
        //    result.Headers.Add("My-Headers-Info", "ABC123");

        //    return Ok("请求头信息为：" + info);
        //}

        public class Success {
            public string Key { get; set; }
        }
        public class Failure
        {
            public string failure { get; set; }
        }
      
    }
}
