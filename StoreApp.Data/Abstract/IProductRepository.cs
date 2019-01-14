using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products();
        Task<int> SaveProductAsync(Product product);
        Task<Product> DeleteProductAsync(int id);
    }
}
