 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using web_project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace web_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly web_projectContext _context;

        public HomeController(
             web_projectContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
         //  ViewBag.CurrentUserName = currentUser.UserName;
            }
            //var messages = await _context.Messages.ToListAsync();
            //ViewBag.data = messages;
            return View();
        }


        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return Error();
        }
        public IActionResult Error()
        {

            return View();
        }



        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ViewLogIn()
        {
            AppManage.LoggedInType = 0;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult AError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }



}
