using System.Collections.Generic;
using _2280600869_NgoBichHang_Lab02.Models;

namespace _2280600869_NgoBichHang_Lab02.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
