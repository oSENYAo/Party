using Party.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Party.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MainPage");
        }
        [HttpGet]
        public ViewResult ReGuest1()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ReGuest1(GuestResposne guest)
        {
            if (ModelState.IsValid)
            {
                MyRepository.AddResponse(guest);
                return View("Thanks", guest);
            }
            else
            {
                return View();
            }
        }
        public ViewResult Guests()
        {
            return View(MyRepository.Resposnes.Where(r => r.WillAttend == true));
        }

    }
}
