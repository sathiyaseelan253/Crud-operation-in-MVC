using System.Collections.Generic;
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
            laptop.DeleteItem(id);
            TempData["Message"] = "Item Deleted Successfully!";
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
           LaptopSpecification specification= laptop.GetLaptopById(id);
            return View(specification);

        }
        [HttpPost]
        public ActionResult Update(LaptopSpecification specification)
        {
            laptop.UpdateItems(specification);
            TempData["Message"] = "Item Updated Successfully!";
            return RedirectToAction("Index");
        }
      
    }
}