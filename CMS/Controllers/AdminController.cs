using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using CMS.Models.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using IdentityDbContext = CMS.Models.IdentityDbContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private readonly IdentityDbContext identityDbContext;

        public AdminController(RoleManager<IdentityRole> roleMgr, UserManager<AppUser> userMrg, SignInManager<AppUser> signMgr)
        {
            roleManager = roleMgr;
            userManager = userMrg;
            signInManager = signMgr;
            identityDbContext = new IdentityDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Role()
        {
            ViewBag.Title = "All Roles";
            return View(roleManager.Roles);
        }

        public IActionResult CreateRole()
        {
            ViewBag.Title = "Create Role";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([Required]string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Role");
                else
                    AddErrorsFromResult(result);
            }
            return View(name);
        }
        public IActionResult CreateUser()
        {
            ViewBag.Title = "Create User";
            
            var list = identityDbContext.AspNetRoles.ToList();
            var selectlist = new SelectList(list, "Name", "Name");
            ViewBag.select = selectlist;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = new IdentityResult() ;

                AppUser appuser = new AppUser
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber=user.PhoneNumber
                };
                
                result = await userManager.CreateAsync(appuser, user.Password);

                if (result.Succeeded)
                {
                    var data= await identityDbContext.AspNetUsers.SingleOrDefaultAsync(w => w.UserName == user.UserName);
                    //data.PhoneNumber = user.PhoneNumber;
                    if (user.Role == "Admin") {
                        data.Admin = true;
                    }
                    //data.PhoneNumber = ;
                    await RefreshAsync(data);
                    identityDbContext.Update(data);
                    await identityDbContext.SaveChangesAsync();
                        result = await userManager.AddToRoleAsync(appuser,user.Role);
                    return Redirect("/User/AllUser");
                    //ViewBag.Result = "User Created";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                    
                }
            }
            var list = identityDbContext.AspNetRoles.ToList();
            var selectlist = new SelectList(list, "Name", "Name");
            ViewBag.select = selectlist;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Role");
                else
                    AddErrorsFromResult(result);
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Role", roleManager.Roles);
        }

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
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