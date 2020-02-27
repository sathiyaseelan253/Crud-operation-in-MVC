using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsItems;
using Product.Entity;

namespace ActionSelectorsInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("Details")]
        public ActionResult Index()
        {
            Accesories accesories = new Accesories();
            List<Items> listOfItems= accesories.GetElectronicsItems();
            return View("Index",listOfItems);
        }
    }
}