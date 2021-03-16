
using System;
using Microsoft.AspNetCore.Mvc;
using Retail.Repository.EntityModels;
using Retail.Services.Interface;
using Retail.ViewModels;

namespace Retail.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private object _productRepository;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.Get());
        }

        [HttpPost]
        public IActionResult Add([FromBody] ProductViewModel productViewModel)
        {
            _productService.Add(productViewModel);
            return Ok();
        }

        [HttpGet("{productid}", Name = "Get")]
        public IActionResult Get(Guid productid)
        {
            Product product = _productService.getById(productid);
            if (product == null)
            {
                return NotFound("The  record couldn't be found.");
            }
            return Ok(product);
        }
        [HttpPut("{productid}")]
        public IActionResult Put(Guid  productid, [FromBody] ProductViewModel product)
        {
            if (product == null)
            {
                return BadRequest("Product is null.");
            }
            Product productToUpdate = _productService.getById(productid);
            if (productToUpdate == null)
            {
                return NotFound("The Product record couldn't be found.");
            }
            _productService.Update(productToUpdate,product);
            return NoContent();
        }
        [HttpDelete("{productid}")]
        public IActionResult Delete(Guid productid)
        {
            Product product = _productService.getById(productid);
            if (product == null)
            {
                return NotFound("The product record couldn't be found.");
            }
            _productService.Delete(product);
            return NoContent();
        }

    }
}

   
