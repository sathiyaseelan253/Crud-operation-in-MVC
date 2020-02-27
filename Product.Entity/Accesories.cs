using Product.Entity;
using System;
using System.Collections.Generic;

namespace ElectronicsItems
{
    public class Accesories
    {
        List<Items> productList = new List<Items>()
            {
                new Items() { ProductID = 1, Name = "Desktop", Price = 34000, Category = "Electronics", Description="DELL Inspiron 3477 All-in-One Desktop (Core i3/4GB/1TB/Windows 10/Integrated Graphics), Black"},
                new Items() { ProductID = 2, Name = "Laptop", Price = 50000, Category = "Electronics", Description="10th Generation Intel® Core™ i5 processor,Windows 10 Home Single Language 64,1 TB 5400 rpm SATA,8 GB DDR4 - 2666 SDRAM(1 x 8 GB),Intel® UHD Graphics" },
                new Items() { ProductID = 3, Name = "Router", Price = 4000, Category = "Electronics", Description="Netgear R6350 AC1750 Smart WiFi Router (Black)" },
                new Items() { ProductID = 4, Name = "Mouse", Price = 300, Category = "Electronics", Description="HP X1000 Wired Mouse (Black/Grey)" },
                new Items() { ProductID = 5, Name = "USB HDD", Price = 7000, Category = "Electronics" , Description="Seagate Expansion Portable 1.5TB External Hard Drive HDD – USB 3.0 for PC Laptop (STEA1500400)"},
                new Items() { ProductID = 6, Name = "LCD", Price = 34000, Category = "Electronics" , Description="LG 27 4K UHD IPS Monitor with HDR10 with USB Type-C Connectivity and FreeSync (2018)"}
            };
        public  List<Items> GetElectronicsItems()
        {
              return productList;
        }
        public Items GetProductById(int Id)
        {
            return productList.Find(id => id.ProductID == Id);
        }
        public void Update(Items item)
        {
            Items InList = GetProductById(item.ProductID);
            InList.ProductID = item.ProductID;
            InList.Name = item.Name;
            InList.Description = item.Description;
            InList.Price = item.Price;
        }
    }
}
