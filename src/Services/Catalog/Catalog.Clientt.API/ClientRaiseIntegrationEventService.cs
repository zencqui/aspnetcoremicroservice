using System;
using System.Threading.Tasks;
using EventBus.Abstractions;
using EventBus.Events;

namespace Catalog.Clientt.API
{
    public class ClientRaiseIntegrationEventService : IClientRaiseIntegrationEventService
    {
        private readonly IEventBus _eventBus;

        public ClientRaiseIntegrationEventService(IEventBus eventBus)
        {
            _eventBus = eventBus ?? throw new ArgumentException(nameof(eventBus));
        }
        public async Task PublishThroughEventBusAsync(IntegrationEvent evt)
        {
            _eventBus.Publish(evt);
        }
    }
}