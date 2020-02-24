using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
       
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
    }
}