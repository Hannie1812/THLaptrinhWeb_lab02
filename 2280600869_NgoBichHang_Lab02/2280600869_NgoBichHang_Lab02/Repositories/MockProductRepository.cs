using System.Collections.Generic;
using System.Linq;
using _2280600869_NgoBichHang_Lab02.Models;

namespace _2280600869_NgoBichHang_Lab02.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public MockProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1000, Description = "A high-end laptop", CategoryId = 1},
                new Product { Id = 2, Name = "Desktop PC", Price = 1200, Description = "Powerful desktop computer", CategoryId = 2 },
                new Product { Id = 3, Name = "Tablet", Price = 500, Description = "Portable tablet device", CategoryId = 3 },
                new Product { Id = 4, Name = "Smartphone", Price = 800, Description = "Latest smartphone model", CategoryId = 4 },
                new Product { Id = 5, Name = "Wireless Mouse", Price = 50, Description = "Ergonomic wireless mouse", CategoryId = 5 },
                new Product { Id = 6, Name = "Bluetooth Keyboard", Price = 70, Description = "Compact Bluetooth keyboard", CategoryId = 5 }
                };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }
        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
