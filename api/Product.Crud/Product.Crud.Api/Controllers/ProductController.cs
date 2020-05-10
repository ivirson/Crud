using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductCrud.BLL.Repository;
using ProductCrud.Models;

namespace ProductCrud.Api.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<Product> Read()
        {
            return _productRepository.Read();
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult ReadById(long id)
        {
            var product = _productRepository.ReadById(id);
            if (product == null)
            {
                return NotFound();
            }
            return new ObjectResult(product);
        }
    }
}
