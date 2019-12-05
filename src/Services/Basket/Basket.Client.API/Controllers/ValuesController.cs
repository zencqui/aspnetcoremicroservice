using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Client.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private readonly IBasketChangedIntegrationEventService _basketChangedIntegrationEventService;

        //public ValuesController(IBasketChangedIntegrationEventService basketChangedIntegrationEventService)
        //{
        //    _basketChangedIntegrationEventService = basketChangedIntegrationEventService 
        //                                            ?? throw new ArgumentException(nameof(basketChangedIntegrationEventService));
        //}

        public ValuesController()
        {

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            //await _basketChangedIntegrationEventService.PublishThroughEventBusAsync(
            //    new BasketChangedIntegrationEvent("Message from Basket client."));
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
