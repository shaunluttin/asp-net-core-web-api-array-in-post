using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_web_api_array_in_post.Controllers
{
    public class Product
    {
        public string Sku { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
    }

    public class Cart
    {
        public List<Product> Product { get; set; }
        public string ShipToZip { get; set; }
        public string ShipMethod { get; set; }
    }

    public class CartBody
    {
        public Cart Cart { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public ActionResult<CartBody> Post(CartBody cartBody)
        {
            return cartBody;
        }
    }
}
