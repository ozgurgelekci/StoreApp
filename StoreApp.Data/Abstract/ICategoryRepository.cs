using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories();
        Task<int> SaveCategoryAsync(Category category);
        Task<Category> DeleteCategoryAsync(int id);
    }
}
