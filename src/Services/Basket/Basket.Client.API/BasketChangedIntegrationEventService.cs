using System;
using System.Threading.Tasks;
using EventBus.Abstractions;
using EventBus.Events;

namespace Basket.Client.API
{
    public class BasketChangedIntegrationEventService : IBasketChangedIntegrationEventService
    {
        private readonly IEventBus _eventBus;

        public BasketChangedIntegrationEventService(IEventBus eventBus)
        {
            _eventBus = eventBus ?? throw new ArgumentException(nameof(eventBus));
        }
        public Task PublishThroughEventBusAsync(IntegrationEvent evt)
        {
            _eventBus.Publish(evt);
            return Task.CompletedTask;
        }
    }
}