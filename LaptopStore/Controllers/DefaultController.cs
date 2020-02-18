using System.Collections.Generic;
using System.Web.Mvc;
using Laptop.Entity;
using LaptopItems;

namespace LaptopStore.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        LaptopRepository laptop;
        public DefaultController()
        {
            laptop = new LaptopRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<LaptopSpecification> specifications = laptop.GetAllLaptopDetails();
            return View();
        }

        
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Create(LaptopSpecification product)
        {
            laptop.AddLaptop(product);
            TempData["Message"] = "Item added successfully";
            return RedirectToAction("Index");
        }

       
        public ActionResult Delete(int id)
        {
            laptop.DeleteEmployee(id);
            TempData["Message"] = "Item Deleted Successfully!";
            return RedirectToAction("Index");
            
        }



    }
}
