using System.Threading.Tasks;
using EventBus.Abstractions;

namespace Basket.Client.API
{
    public class ClientMessageIntegrationEventHandler : IIntegrationEventHandler<ClientMessageIntegrationEvent>
    {
        public Task Handle(ClientMessageIntegrationEvent @event)
        {
            var message = @event.Message;
            return Task.CompletedTask;
        }
    }
}