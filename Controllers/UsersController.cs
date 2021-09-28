using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using web_project.Data;
using web_project.Models;

namespace web_project.Controllers
{
  
    public class UsersController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<UsersController> _logger;

        public UsersController(
            web_projectContext context,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<UsersController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
            AppManage.ErrorMsg = String.Empty;
        }


        private readonly web_projectContext _context;
        public static int UserId = 0;

      
        public async Task<IActionResult> Index()
        {      
                return View(await _context.Users.ToListAsync());
        }

        public async Task<IActionResult> MainHome()
        {
            if (true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewLogIn", "Home");

            }
        }

        public IActionResult CreateUser()
        {
            ViewData["BankId"] = new SelectList(_context.Set<Bank>(), "Id", "Id");
            return View();
        }
        public IActionResult CreateTeacher()
        {
            ViewData["BankId"] = new SelectList(_context.Set<Bank>(), "Id", "Id");
            return View();
        }
        public IActionResult CreateStudent()
        {
            return View();
        }


        [AllowAnonymous]
        public async Task<IActionResult> LogIn([Bind("UserName,Password")] User user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");
                return RedirectToAction("Index", "Home");              
            }
            else
            {
                AppManage.ErrorMsg = "Invalid LogIn";
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return RedirectToAction("ViewLogIn", "Home", user);

            }

        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
         
                return View();                       
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DetailsA(int id)
        {

           // var a = this.User;
           // var user = await _context.User
           //.FirstOrDefaultAsync(m => m.Id == id);
           // if (user == null)
           // {
           //     return NotFound();
           // }

            return View();

        }


        public async Task<IActionResult> LogOut()
        {
            string returnUrl = "";
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            if (returnUrl != null)
            {
                return RedirectToAction("ViewLogIn", "Home");

              
            }
            else
            {
                return View();
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTeachar([Bind("Id, UserName, Password, TelephoneNo, FirstName, LastName, UserTypeId, IsActive, Email, Image, Nic, Grade, BankId, Branch, AccountNo, AccountName")] User user)
        {
          string  returnUrl = Url.Content("~/");

            if (ModelState.IsValid)
            {
                try
                {
                
                    var IdentityUser = new IdentityUser { UserName = user.UserName, Email = user.Email  };
                    
                    var result = await _userManager.CreateAsync(IdentityUser, user.Password);
                    if (result.Succeeded)
                    {
                      
                       await _userManager.AddToRoleAsync(IdentityUser,"Officer");
                        _logger.LogInformation("User created a new account with password.");

                        await _signInManager.SignInAsync(IdentityUser, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return RedirectToAction("Index", "Home");
                   
                }
                catch (Exception ex)
                {

                }

            }

            return View(user);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent([Bind("Id, UserName, Password, TelephoneNo, FirstName, LastName, UserTypeId, IsActive, Email, Image, Nic, Grade, BankId, Branch, AccountNo, AccountName")] User user)
        {
            string returnUrl = Url.Content("~/");

            if (ModelState.IsValid)
            {
                try
                {


                    var IdentityUser = new IdentityUser { UserName = user.UserName, Email = user.Email };

                    var result = await _userManager.CreateAsync(IdentityUser, user.Password);
                    if (result.Succeeded)
                    {

                        await _userManager.AddToRoleAsync(IdentityUser, "Officer");
                        _logger.LogInformation("User created a new account with password.");

                        await _signInManager.SignInAsync(IdentityUser, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return RedirectToAction("Index", "Home");

                }
                catch (Exception ex)
                {

                }

            }

            return View( user);


        }


        public async Task<IActionResult> Edit(int id)
        {
           
            //var user = await _context.User.FindAsync(id);
            //if (user == null)
            //{

            //    return RedirectToAction("ViewLogIn", "Home");
            //}
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Password,TelephoneNo,FirstName,LastName,UserTypeId,IsActive,Email,Image,Nic,Grade,BankId,Branch,AccountNo,AccountName")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.IsActive = 1;
                    _context.Update(user);


                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }


            }
            return RedirectToAction("Index", "Users");

        }


        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.User
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    if (AppManage.LoggedInType <= 0)
        //    {
        //        return RedirectToAction("ViewLogIn", "Home");
        //    }
        //    else
        //    {
        //        return View(user);


        //    }
        //}

        //// POST: Users/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var user = await _context.User.FindAsync(id);
        //    user.IsActive = 1;

        //    _context.User.Update(user);

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index", "Users");

        //}

        //private bool UserExists(int id)
        //{
        //    return _context.User.Any(e => e.Id == id);
        //}


    }
}
