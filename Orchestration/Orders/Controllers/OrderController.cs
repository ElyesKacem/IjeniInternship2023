using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        //POST api/OrderController
        [HttpPost]
        public int Post([FromBody] Order order)
        {
            Console.WriteLine($"Created new order: {order.ProductName}");
            return 1;
        }

        //DELETE api/OrderController/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine($"Deleted order: {id}");
        }
    }
}
