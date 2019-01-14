using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Abstract
{
   public interface IOrderRepository
    {
        IEnumerable<Order> Orders();
        Task<int> SaveOrderAsync(Order order);
        Task<Order> DeleteOrderAsync(int id);
    }
}
