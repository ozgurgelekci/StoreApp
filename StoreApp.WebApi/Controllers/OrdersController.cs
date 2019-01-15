using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete.EntityFramework;
using StoreApp.Entities.Concrete;

namespace StoreApp.WebApi.Controllers
{
    public class OrdersController : ApiController
    {
        private IOrderRepository _orderRepository;

        public OrdersController()
        {
            //Örnek oldugundan Dependency Injection ile uğraşmadım.
            _orderRepository = new EfOrderRepository();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.Orders();
        }

        public Order GetOrder(int id)
        {
            return _orderRepository.Orders().FirstOrDefault(x => x.Id == id);
        }

        public async Task PostOrder(Order order)
        {
            await _orderRepository.SaveOrderAsync(order);
        }

        public async Task DeleteOrder(int id)
        {
            await _orderRepository.DeleteOrderAsync(id);
        }
    }
}
