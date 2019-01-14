using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Data.Abstract;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfOrderLineRepository : IOrderLineRepository
    {
        StoreAppContext context = new StoreAppContext();

        public IEnumerable<OrderLine> OrderLines()
        {
            return context.OrderLines;
        }

        public async Task<int> SaveOrderLineAsync(OrderLine orderLine)
        {
            if (orderLine.Id == 0)
            {
                context.OrderLines.Add(orderLine);
            }
            else
            {
                OrderLine orderLineToUpdate = context.OrderLines.Find(orderLine.Id);
                if (orderLineToUpdate != null)
                {
                    orderLineToUpdate.Count = orderLine.ProductId;
                    orderLineToUpdate.OrderId = orderLine.OrderId;
                }
            }

            return await context.SaveChangesAsync();
        }

        public async Task<OrderLine> DeleteOrderLineAsync(int id)
        {
            OrderLine findOrderLine = context.OrderLines.Find(id);

            if (findOrderLine != null)
            {
                context.OrderLines.Remove(findOrderLine);
            }

            await context.SaveChangesAsync();
            return findOrderLine;
        }
    }
}
