using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsItems;
using Product.Entity;

namespace ActionVerbsInMvc.Controllers
{
    public class AccesoriesController : Controller
    {
        // GET: Accesories
        Accesories accesories = new Accesories();
        
        public ActionResult Index()
        {
            List<Items> listOfProducts = accesories.GetElectronicsItems();

            return View(listOfProducts);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Items specifiedItem = accesories.GetProductById(id);
          
            return View(specifiedItem);
        }
        [HttpPost]
        public ActionResult Update([Bind(Exclude = "Price,ProductID", Include = "Name,Category,Description")]Items items)
        {
            accesories.Update(items);
            if (ModelState.IsValid)
            {

                TempData["Message"] = "Successfully Updated";
            }
            return RedirectToAction("Index");
        }
    }
}