using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entities.Abstract;

namespace StoreApp.Entities.Concrete
{
    public class OrderLine : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
