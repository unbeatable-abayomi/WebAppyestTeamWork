using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppyest.Controllers
{
    public class MainController : Controller
    {

        public IActionResult Resources()
        {
            return View();
        }
        public IActionResult ProjectLists()
        {
            return View();
        }

        public IActionResult Taskboard()
        {
            return View();
        }

        public IActionResult Activities()
        {
            return View();
        }

        public IActionResult Players()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
