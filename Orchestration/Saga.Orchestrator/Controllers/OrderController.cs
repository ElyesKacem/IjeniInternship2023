using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Saga.Orchestrator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IHttpClientFactory httpClientFactory;
        public OrderController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        // POST api/OrderController
        [HttpPost]
        public async Task<OrderResponse> Post ([FromBody] Order order)
        {
            var request = JsonConvert.SerializeObject(order);

            // Create order
            var orderClient = httpClientFactory.CreateClient("Order");
            var orderResponse = await orderClient.PostAsync("/api/order", new StringContent(request, Encoding.UTF8, "application/JSON"));
            var orderId = await orderResponse.Content.ReadAsStringAsync();

            // Update inventory
            var inventoryId = string.Empty;
            try
            {
                var inventoryClient = httpClientFactory.CreateClient("Inventory");
                var inventoryResponse = await inventoryClient.PostAsync("/api/inventory",
                    new StringContent(request, Encoding.UTF8, "application/JSON"));
                if (inventoryResponse.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new Exception(inventoryResponse.ReasonPhrase);
                //chofeha
                inventoryId = await inventoryResponse.Content.ReadAsStringAsync();
            }
            catch (Exception exc)
            {
                await orderClient.DeleteAsync($"/api/order/{orderId}");
                return new OrderResponse { Success = false, Reason = exc.Message };
            }

            // Send notification
            var notifierClient = httpClientFactory.CreateClient("Notifier");
            var notifierResponse = await notifierClient.PostAsync("/api/notifier",
                new StringContent(request, Encoding.UTF8, "application/JSON"));
            var notifierId = await notifierResponse.Content.ReadAsStringAsync();

            Console.WriteLine($"Order: {orderId}, Inventory: {inventoryId}, Notification: {notifierId}");
            return new OrderResponse {OrderId = orderId, Success = true };
        }

    }
}
