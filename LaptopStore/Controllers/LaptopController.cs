using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaptopItems;
using Laptop.Entity;

namespace LaptopStore.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        LaptopRepository laptop;
        public LaptopController()
        {
            laptop = new LaptopRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<LaptopSpecification> specifications = laptop.GetAllLaptopDetails();
            return View(specifications);
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