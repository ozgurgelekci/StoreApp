using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entities.Abstract;

namespace StoreApp.Entities.Concrete
{
    public class Category : IEntity
    {
        //public Category()
        //{
        //    Products = new List<Product>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
