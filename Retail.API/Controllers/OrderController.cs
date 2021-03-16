using Microsoft.AspNetCore.Mvc;
using Retail.Models.ViewModels;
using Retail.Services.Interface;
using System;
using System.Threading.Tasks;


namespace Retail.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderProductService _orderService;

        public OrderController(IOrderProductService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _orderService.GetOrderDetails();
            return Ok(result);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _orderService.GetOrderDetail(id);
            if (result == null)
            {
                return NotFound("Order not Found");
            }
            return Ok(result);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderViewModel order)
        {
            var newOrder = await _orderService.PlaceOrder(order);
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _orderService.DeleteOrder(id);
            return Ok();
        }
    }
}

