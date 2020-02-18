using System.Collections.Generic;
using Laptop.Entity;


namespace LaptopItems
{
    public class LaptopRepository
    {
        public static List<LaptopSpecification> products = new List<LaptopSpecification>();
        static LaptopRepository()
        {
            products.Add(new LaptopSpecification { Id = 1, Brand = "HP pavilion", Price=40000,Description = "10th Generation Intel® Core™ i5 processor,Windows 10 Home Single Language 64,1 TB 5400 rpm SATA,8 GB DDR4 - 2666 SDRAM(1 x 8 GB),Intel® UHD Graphics" });
            products.Add(new LaptopSpecification { Id = 2, Brand = "Dell", Price = 30000, Description = "9th Generation Intel® Core™ i5-9300H,9th Generation Intel® Core™ i5-9300H,Windows 10 Home Plus Single Language,NVIDIA® GeForce® GTX 1050 3GB GDDR5,8GB 2x4GB DDR4 2666MHz" });
            products.Add(new LaptopSpecification { Id = 3, Brand ="Lenovo", Price = 35000, Description = "Powerful, intuitive, & secure 35.56cms (14) laptop,Skype - certified mics,full - sized keyboard,Optional Intel® Optane™ memory & WiFi 6"});
            products.Add(new LaptopSpecification { Id = 4, Brand = "HP Omen Gaming Laptop", Price = 80000, Description = "HP Omen Core i7 9th Gen 15.6-inch FHD Gaming Laptop (16GB/1TB HDD + 512GB SSD/Windows 10/NVIDIA GTX 1650 4GB Graphics/Shadow Black), 15-dh0135TX"});
           
        }
        public IEnumerable<LaptopSpecification> GetAllLaptopDetails()
        {
            return products;
        }
        public void AddLaptop(LaptopSpecification product)
        {
            products.Add(product);
        }
        public LaptopSpecification GetLaptopById(int lapId)
        {
            return products.Find(id => id.Id == lapId);
        }
        public void DeleteItem(int id)
        {
            LaptopSpecification item = GetLaptopById(id);
            if (item != null)
                products.Remove(item);
        }
        public void UpdateItems(LaptopSpecification item)
        {
            LaptopSpecification specification = GetLaptopById(item.Id);
            specification.Id = item.Id;
            specification.Brand = item.Brand;
            specification.Price = item.Price;
            specification.Description = item.Description;
        }
    }
}
