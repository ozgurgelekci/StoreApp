using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entities.Abstract;

namespace StoreApp.Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }
}
