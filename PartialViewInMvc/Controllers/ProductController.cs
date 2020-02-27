using Product.Entity;
using Laptop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewInMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Items> products = new List<Items>()
            {
                new Items{ ProductID=1, Name="Oppo F15 mobile phone", Category="Mobile", Description="Unicorn White, 8GB RAM, 128GB Storage", Price=19990},
                new Items{ ProductID=2, Name="JBL Headphones", Category="Mobile Accesories", Description="JBL E25BT Signature Sound Wireless in-Ear Headphones with Mic (Blue)", Price=1990},
                new Items{ ProductID=3, Name="Canon EOS M200", Category="Camera", Description="Canon EOS M200 Mirrorless Camera, EF-M15-45mm f/3.5-6.3 is STM and EF-M55-200mm f/4.5-6.3 is STM Lens, 24.1 MP, 16 GB Memory Card and Carry case", Price=49890},
                new Items{ ProductID=4, Name="USB Keyboard & USB Mouse Combo", Category="Computer Accesories", Description="ZEBRONICS Gaming Multimedia USB Keyboard & USB Mouse Combo -Transformer", Price=1090},
                new Items{ ProductID=5, Name="HP Omen laptop", Category="Laptop", Description="HP Omen Core i7 9th Gen 15.6-inch FHD Gaming Laptop (16GB/1TB HDD + 512GB SSD/Windows 10/NVIDIA GTX 1650 4GB Graphics/Shadow Black), 15-dh0135TX", Price= 109990}
            };
            return View(products);
        }
        public ActionResult GetLaptopDetails()
        {
            List<LaptopSpecification> products = new List<LaptopSpecification>()
            {
                new LaptopSpecification { Id = 1, Brand = "HP pavilion", Price = 40000, Description = "10th Generation Intel® Core™ i5 processor,Windows 10 Home Single Language 64,1 TB 5400 rpm SATA,8 GB DDR4 - 2666 SDRAM(1 x 8 GB),Intel® UHD Graphics" },
                new LaptopSpecification { Id = 2, Brand = "Dell", Price = 30000, Description = "9th Generation Intel® Core™ i5-9300H,9th Generation Intel® Core™ i5-9300H,Windows 10 Home Plus Single Language,NVIDIA® GeForce® GTX 1050 3GB GDDR5,8GB 2x4GB DDR4 2666MHz" },
                new LaptopSpecification { Id = 3, Brand = "Lenovo", Price = 35000, Description = "Powerful, intuitive, & secure 35.56cms (14) laptop,Skype - certified mics,full - sized keyboard,Optional Intel® Optane™ memory & WiFi 6" },
                new LaptopSpecification { Id = 4, Brand = "HP Omen Gaming Laptop", Price = 80000, Description = "HP Omen Core i7 9th Gen 15.6-inch FHD Gaming Laptop (16GB/1TB HDD + 512GB SSD/Windows 10/NVIDIA GTX 1650 4GB Graphics/Shadow Black, 15-dh0135TX" }
            };

            return View(products);
        }
    }
}