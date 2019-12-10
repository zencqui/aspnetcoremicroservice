using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Client.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IClientRaiseIntegrationEventService _clientRaiseIntegrationEventService;

        public ValuesController(IClientRaiseIntegrationEventService clientRaiseIntegrationEventService)
        {
            _clientRaiseIntegrationEventService = clientRaiseIntegrationEventService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{productPrice}")]
        public async Task<ActionResult<string>> ChangeProductPrice(double productPrice)
        {
            await _clientRaiseIntegrationEventService.PublishThroughEventBusAsync(new ChangedProductPriceIntegrationEvent($"A product price has been changed: {productPrice}"));
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
