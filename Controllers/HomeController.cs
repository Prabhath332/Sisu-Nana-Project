using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace web_project.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
           
        }

       
        public IActionResult Index()
        {
            return View();
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
