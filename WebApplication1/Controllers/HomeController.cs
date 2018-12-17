using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            
            return Redirect("bankid:///?autostarttoken=");
            return View();
        }


        public IActionResult Redirect()
        {
            return Redirect("bankid:///?autostarttoken=");
            return View();
        }

        public IActionResult Google()
        {
            return Redirect("https://www.google.com/");
            return View();
        }

        public IActionResult JsRedirect()
        {
            return View();
        }

        public IActionResult JsRedirect2()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
