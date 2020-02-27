using System.Collections.Generic;
using System.Web.Mvc;
using Account.Entity;

namespace LaptopStore.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        accountRepository acc;
       public AccountController()
        {
            acc = new accountRepository();
        }
        public ActionResult Login()
        {
            IEnumerable<Accounts> Ids = acc.GetAllAccounts();
            return View(Ids);
        }
        [HttpPost]
        public ActionResult Login(Accounts ids)

        {
            bool status= accountRepository.CheckIds(ids);
            if (status)
            {
                if (ModelState.IsValid)
                {
                    return RedirectToRoute("www.google.com");
                }
            }
            else
            {
                Response.Write("Invalid");
            }
            return View();

        }
        public ActionResult SignIn()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
           
        }
    }
}