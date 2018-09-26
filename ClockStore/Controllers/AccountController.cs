using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClockStore.Models;
using Microsoft.AspNetCore.Identity;

namespace ClockStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        //responds on GET //Account/Register

        public IActionResult Register()
        {
            return View();
        }

        //responds on POST /Account/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(string username, string password)
        {
            return Ok();
        }
    }
}