using Microsoft.AspNetCore.Mvc;
using Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAppResource _sharedLocalizer;
        public AccountController(IAppResource sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        public IActionResult Index()
        {
    
            return View();
        }

        public IActionResult Login()
        {
            string result = _sharedLocalizer.GetResource("Water");
            ViewBag.Water = result;
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
