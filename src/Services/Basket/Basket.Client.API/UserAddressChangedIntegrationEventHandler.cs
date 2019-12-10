using System;
using System.Threading.Tasks;
using EventBus.Abstractions;

namespace Basket.Client.API
{
    public class UserAddressChangedIntegrationEventHandler : IIntegrationEventHandler<UserAddressChangedIntegrationEvent>
    {
        public Task Handle(UserAddressChangedIntegrationEvent @event)
        {
            // Do stuff here i.e. updating database
            var message = @event.Message;

            Console.WriteLine(message);

            return Task.CompletedTask;
        }
    }
}