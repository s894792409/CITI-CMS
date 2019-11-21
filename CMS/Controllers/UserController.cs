using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Hosting;

namespace CMS.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private UserManager<AppUser> userManager;
        private IUserValidator<AppUser> userValidator;
        private IPasswordValidator<AppUser> passwordValidator;
        private IPasswordHasher<AppUser> passwordHasher;
        private SignInManager<AppUser> signInManager;
        private IdentityDbContext identityDbContext;
        private IHostingEnvironment _hostingEnvironment;

        public UserController(UserManager<AppUser> userMgr, IUserValidator<AppUser> userValid, IPasswordValidator<AppUser> passValid, IPasswordHasher<AppUser> passwordHash, SignInManager<AppUser> signMgr,IHostingEnvironment hosting)
        {
            userManager = userMgr;
            userValidator = userValid;
            passwordValidator = passValid;
            passwordHasher = passwordHash;
            signInManager = signMgr;
            identityDbContext = new IdentityDbContext();
            _hostingEnvironment = hosting;
        }

        public IActionResult Index()
        {
            ViewBag.rows = 5;
            return View();
        }
        public async Task<IActionResult> AllUser()
        {
            ViewBag.rows = 5;
            return View(await identityDbContext.AspNetUsers.ToListAsync());
        }

        [AllowAnonymous]
        public ViewResult Create()
        {
            ViewBag.Title = "Create User";
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                };

                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    result = await userManager.AddToRoleAsync(appUser, "User");
                    if (result.Succeeded)
                    {
                        TempData["result"] = "Account Create - Now please login";
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }

        public async Task<IActionResult> Edit()
        {
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            ViewBag.Title = "Update User";
            return View(user);
        }

        //public async Task<IActionResult> Edit(string username)
        //{
        //    UserInfo info= await identityDbContext.AspNetUsers.SingleOrDefaultAsync(s => s.UserName == username);
        //    AppUser user = new AppUser();
        //    User
        //    ViewBag.Title = "Update User";
        //    return View(user);
        //}
        public async Task<IActionResult> RefreshKey()
        {
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            user.UserKey = MakeKey(15);
            IdentityResult result = await userManager.UpdateAsync(user);
            if (result.Succeeded)
                ViewBag.Result = "Update Successful";
            else
                AddErrorsFromResult(result);
            return RedirectToAction("Edit");
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
        [HttpPost]
        public async Task<IActionResult> Edit(AppUser appUser, string Password)
        {
            //AppUser user = await userManager.FindByIdAsync(id);
            ViewBag.Title = "Update User";
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                user.Email = appUser.Email;
                IdentityResult validEmail = await userValidator.ValidateAsync(userManager, user);
                if (validEmail.Succeeded)
                    user.Email = appUser.Email;
                else
                    AddErrorsFromResult(validEmail);

                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(Password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, user, Password);
                    if (validPass.Succeeded)
                        user.PasswordHash = passwordHasher.HashPassword(user, Password);
                    else
                        AddErrorsFromResult(validPass);
                }
                else
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, user, appUser.PasswordHash);
                    user.PasswordHash = appUser.PasswordHash;
                }

                if (validEmail.Succeeded && validPass.Succeeded)
                {
                    user.PhoneNumber = appUser.PhoneNumber;
                    user.Country = appUser.Country;
                    user.Age = appUser.Age;

                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        ViewBag.Result = "Update Successful";
                    else
                        AddErrorsFromResult(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(user);
        }

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

        public async Task<IActionResult> Delete(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            var user = await identityDbContext.AspNetUsers.ToListAsync();
            UserInfo user1 = await identityDbContext.AspNetUsers.SingleOrDefaultAsync(s => s.UserName == username);
            UserInfo user2 = new UserInfo();
            user2.UserName = username;
            return View(user1);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string username)
        {
            AppUser appuser = await userManager.GetUserAsync(HttpContext.User);
            if (username == appuser.UserName) {
                ViewBag.error = "You cannot delete the account you are currently logged into!";
                return View();
            }
            if (username == "admin") {
                ViewBag.error = "You cannot delete the admin account!";
                return View();
            }
            var user = await identityDbContext.AspNetUsers.SingleOrDefaultAsync(s => s.UserName == username);
            identityDbContext.AspNetUsers.Remove(user);
            await identityDbContext.SaveChangesAsync();
            string action = $"delete user '{user.UserName}'";
            await insertLogAsync(action);
            return RedirectToAction(nameof(AllUser));
        }
        [HttpPost]
        public async Task<IActionResult> checkPassword()
        {
            bool success = false;
            
            string password = Request.Form["Password"];
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            var roles = await userManager.GetRolesAsync(user);
            if (roles.FirstOrDefault() == "Admin")
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, password, false, false);
                if (result.Succeeded)
                {
                    success = true;
                }
            }
            return Json(new { success = success });
        }

        [HttpPost]
        public async Task insertLogAsync(string action)
        {
            string webrootpath = _hostingEnvironment.WebRootPath;
            string filename = $"{DateTime.Now.Date.ToString("dd MMM yyyy", DateTimeFormatInfo.InvariantInfo)}.txt";
            string path = Path.Combine(webrootpath, "Log", filename).ToString();
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                StreamWriter sw = file.AppendText();
                string time = DateTime.Now.ToString("dd MMM yyyy,hh:mm:ss", DateTimeFormatInfo.InvariantInfo);
                AppUser user = await userManager.GetUserAsync(HttpContext.User);
                sw.WriteLine($"[{time}] {user.UserName} {action}");
                sw.Close();
            }
            else
            {
                // await file.Create();
                StreamWriter sw = file.CreateText();
                string time = DateTime.Now.ToString("dd MMM yyyy,hh:mm:ss", DateTimeFormatInfo.InvariantInfo);
                AppUser user = await userManager.GetUserAsync(HttpContext.User);
                sw.WriteLine($"[{time}] {user.UserName} {action}");
                sw.Close();
            }
        }
    }
}