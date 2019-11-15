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
                    Email = user.Email
                };
                
                result = await userManager.CreateAsync(appuser, user.Password);

                if (result.Succeeded)
                {
                    var data= await identityDbContext.AspNetUsers.SingleOrDefaultAsync(w => w.UserName == user.UserName);
                    data.PhoneNumber = user.PhoneNumber;
                    if (user.Role == "Admin") {
                        data.Admin = true;
                    }
                    data.PhoneNumber = user.PhoneNumber;
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
    }
}