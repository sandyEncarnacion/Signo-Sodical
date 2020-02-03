using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sodiacal_Sign.Models;

namespace Sodiacal_Sign.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.greeting = hour < 12 ? "Good Mornign" : "Good Afternoon";

            return View("MySodiacalSign");
        }

        [HttpGet]
        public ViewResult ButtonForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ButtonForm(UserForm userForm)
        {

            //Repository.AdduserForm(userForm);
            return View("Sign", userForm);
          
            
            
        }
    }
}
