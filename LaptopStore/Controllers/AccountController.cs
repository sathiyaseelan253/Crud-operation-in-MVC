using System.Web.Mvc;

namespace LaptopStore.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
       
        public ActionResult Login()
        {
            if (ModelState.IsValid)
            {
                return View();
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