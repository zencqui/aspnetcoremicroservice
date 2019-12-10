using System;
using System.Threading.Tasks;
using EventBus.Abstractions;
using EventBus.Events;

namespace Ordering.API
{
    public class RaiseIntegrationEventService : IRaiseIntegrationEventService
    {
        private readonly IEventBus _eventBus;

        public RaiseIntegrationEventService(IEventBus eventBus)
        {
            _eventBus = eventBus ?? throw new ArgumentException(nameof(eventBus));
        }
        public async Task PublishThroughEventBusAsync(IntegrationEvent evt)
        {
            _eventBus.Publish(evt);
        }
    }
}