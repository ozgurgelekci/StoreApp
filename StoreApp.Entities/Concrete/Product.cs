﻿
using StoreApp.Entities.Abstract;
using StoreApp.Entities.Concrete;

namespace StoreApp.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
