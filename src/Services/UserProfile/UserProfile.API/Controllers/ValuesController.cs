using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserProfile.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRaiseIntegrationEventService _raiseIntegrationEventService;
        private static int _count;

        public ValuesController(IRaiseIntegrationEventService raiseIntegrationEventService)
        {
            _raiseIntegrationEventService = raiseIntegrationEventService;
            //_count = 0;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/angeles city
        [HttpGet("{newAddress}")]
        public async Task<ActionResult<string>> UserAddressChanged(string newAddress)
        {
            await _raiseIntegrationEventService.PublishThroughEventBusAsync(new UserAddressChangedIntegrationEvent($"User address has been changed: {newAddress}_{_count++}"));
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