using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifierController : ControllerBase
    {
        //POST api/NotifierController
        [HttpPost]
        public int Post([FromBody] Notifier notifier)
        {
            Console.WriteLine($"Sent notification for: {notifier.ProductName}");
            return 3;
        }

        //DELETE api/NotifierController/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine($"Sent rollback transaction notification: {id}");
        }
    }
    
}
