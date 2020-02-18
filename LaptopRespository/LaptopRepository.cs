using System.Collections.Generic;
using Laptop.Entity;


namespace LaptopItems
{
    public class LaptopRepository
    {
        public static List<LaptopSpecification> products = new List<LaptopSpecification>();
        static LaptopRepository()
        {
            products.Add(new LaptopSpecification { Id = 1, Brand = "HP pavilion", Price=40000,Description = "1 x Cadbury Dairy Milk Silk Chocolate Bar (150g)" });
            products.Add(new LaptopSpecification { Id = 2, Brand = "Dell", Price = 30000, Description = "AmazonBasics 78 cm Burnt Orange Hardsided Check-in Trolley"});
            products.Add(new LaptopSpecification { Id = 3, Brand ="Lenovo", Price = 35000, Description = "boAt Rockerz 255 Sports Bluetooth Wireless Earphone with Immersive Stereo Sound and Hands Free Mic (Neon)"});
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
        public void DeleteEmployee(int id)
        {
            LaptopSpecification item = GetLaptopById(id);
            if (item != null)
                products.Remove(item);
        }
    }
}
