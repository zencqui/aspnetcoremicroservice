using System.Threading.Tasks;
using EventBus.Abstractions;

namespace Catalog.Clientt.API
{
    public class BasketChangedIntegrationEventHandler : IIntegrationEventHandler<BasketChangedIntegrationEvent>
    {
        public Task Handle(BasketChangedIntegrationEvent @event)
        {
            var message = @event.Message;
            return Task.CompletedTask;
        }
    }
}