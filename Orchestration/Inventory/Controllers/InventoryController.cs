using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        //POST api/InventoryController
        [HttpPost]
        public int Post([FromBody] Inventory inventory)
        {
            throw new Exception("Error creating order");

            Console.WriteLine($"Updated inventory for: {inventory.ProductName}");
            return 2;

        }

        //DELETE api/InventoryController/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine($"Deleted inventory: {id}");
        }
    }
}
