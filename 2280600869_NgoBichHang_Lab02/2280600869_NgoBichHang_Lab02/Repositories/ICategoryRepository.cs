using _2280600869_NgoBichHang_Lab02.Models;

namespace _2280600869_NgoBichHang_Lab02.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
