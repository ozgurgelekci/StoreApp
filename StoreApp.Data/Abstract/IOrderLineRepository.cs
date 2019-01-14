using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Abstract
{
   public  interface IOrderLineRepository
   {
       IEnumerable<OrderLine> OrderLines();
        Task<int> SaveOrderLineAsync(OrderLine orderLine);
        Task<OrderLine> DeleteOrderLineAsync(int id);
    }
}
