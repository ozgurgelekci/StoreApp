using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Data.Abstract;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfOrderRepository : IOrderRepository
    {
        private StoreAppContext context = new StoreAppContext();

        public IEnumerable<Order> Orders()
        {
            return context.Orders;
        }

        public async Task<int> SaveOrderAsync(Order order)
        {
            if (order.Id == 0)
            {
                context.Orders.Add(order);
            }
            else
            {
                Order orderToUpdate = context.Orders.Find(order.Id);
                if (orderToUpdate != null)
                {
                    orderToUpdate.UserName = order.UserName;
                }
            }

            return await context.SaveChangesAsync();
        }

        public async Task<Order> DeleteOrderAsync(int id)
        {
            Order findOrder = context.Orders.Find(id);

            if (findOrder != null)
            {
                context.Orders.Remove(findOrder);
            }

            await context.SaveChangesAsync();
            return findOrder;
        }
    }
}
