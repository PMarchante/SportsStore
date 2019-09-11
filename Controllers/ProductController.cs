using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
        //specified 4 products per page
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        public ViewResult List(int productPage = 1) => View(
           new ProductsListViewModel
           {
               Products = _repo.listOfProducts
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)//skips 0 if we specify how many products per page
                .Take(PageSize),

               PageInfo = new PageInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems = _repo.listOfProducts.Count()
               }
           });
    }
}