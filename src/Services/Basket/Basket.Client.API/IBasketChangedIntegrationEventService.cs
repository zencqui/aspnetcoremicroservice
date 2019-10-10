using System.Threading.Tasks;
using EventBus.Events;

namespace Basket.Client.API
{
    public interface IBasketChangedIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}