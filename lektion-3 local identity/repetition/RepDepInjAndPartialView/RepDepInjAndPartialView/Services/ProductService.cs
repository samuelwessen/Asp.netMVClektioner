using RepDepInjAndPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Services
{
    public class ProductService : IProductService
    {

        private List<Product> _productList { get; set; }

        public ProductService()
        {
            _productList = new List<Product>()
            {
                new Product { Id= 1, Name = "Dell XPS 13 7390", Description = "Core i7 16GB 512GB SSD 13.3", Price = "17499", ImageUrl = "https://dustinweb.azureedge.net/image/614199/960/720/dell-xps-13-7390-core-i7-16gb-512gb-ssd-133.jpg" },
                new Product { Id= 2, Name = "Lenovo ThinkPad X1 Carbon G7 ", Description = "Core i5 8GB 256GB SSD 14", Price = "9999", ImageUrl = "https://dustinweb.azureedge.net/image/547070/960/720/lenovo-thinkpad-x1-carbon-g7-core-i5-8gb-256gb-ssd-14.jpg" },
                new Product { Id= 3, Name = "HP EliteDesk 800 G5 DM", Description = "Core i5 8GB 512GB SSD", Price = "7999", ImageUrl = "https://dustinweb.azureedge.net/image/511236/960/720/hp-elitedesk-800-g5-dm-core-i5-8gb-512gb-ssd.jpg" },
                new Product { Id= 4, Name = "Dell Latitude 5410", Description = "Core i5 8GB 256GB SSD 14", Price = "8399", ImageUrl = "https://dustinweb.azureedge.net/image/587242/960/720/dell-latitude-5410-core-i5-8gb-256gb-ssd-14.jpg" }
            };
        }




        public IEnumerable<Product> GetBestSellers()
        {
            return _productList;
        }

        public IEnumerable<Product> GetLatest()
        {
            return _productList;
        }

        public Product GetProduct(int id)
        {
            return _productList.FirstOrDefault(p => p.Id == id);
        }
    }
}
