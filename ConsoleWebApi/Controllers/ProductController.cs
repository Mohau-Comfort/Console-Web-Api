using ConsoleWebApi.Models;
using ConsoleWebApi.Repositry;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
         
        private readonly IProductRepositry _productRepositry;

        public ProductController(IProductRepositry productRepositry)
        {
            _productRepositry = productRepositry;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepositry.AddProduct(product);

            var products = _productRepositry.GetAllProducts();

            return Ok(products);
        }

    }
}
