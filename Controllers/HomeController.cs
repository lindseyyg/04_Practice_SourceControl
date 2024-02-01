using _04_Practice_SourceControl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_Practice_SourceControl.Controllers
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
    }
}
