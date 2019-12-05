using System;
using System.Threading.Tasks;
using EventBus.Abstractions;

namespace Basket.Client.API
{
    public class ChangedProductPriceIntegrationEventHandler : IIntegrationEventHandler<ChangedProductPriceIntegrationEvent>
    {
        //private readonly IEventBus _eventBus;

        public ChangedProductPriceIntegrationEventHandler()
        {
            
        }
        public Task Handle(ChangedProductPriceIntegrationEvent @event)
        {
            // Do stuff here i.e. updating database
            var message = @event.Message;

            Console.WriteLine(message);

            return Task.CompletedTask;
        }
    }
}