using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saga.Orchestrator.Controllers
{
    public class OrderResponse
    {
        public string OrderId { get; set; }
        public bool Success { get; internal set; }
        public string Reason { get; internal set; }
    }
}
