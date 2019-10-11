using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using Microsoft.AspNetCore.Identity;

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
                    Success respone = new Success();
                    respone.Key = user.UserKey;
                    return Ok(respone);
                }
            }
            Failure failure = new Failure();
            failure.failure = "failure";
            return Ok(failure);
        }
        public class Success {
            public string Key { get; set; }
        }
        public class Failure
        {
            public string failure { get; set; }
        }
      
    }
}
