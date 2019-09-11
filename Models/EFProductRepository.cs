using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public EFProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> listOfProducts => _context.Products;
    }
}
