using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeRepository : IProductRepository
    {
        public IQueryable<Product> listOfProducts => new List<Product>
        {
            new Product{ Name="Golf balls", Price=19.99M},
             new Product{ Name="Black socks", Price=8.99M},
              new Product{ Name="Tennis racket", Price=35.99M}
        }.AsQueryable<Product>();
    }
}
