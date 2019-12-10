using System.Threading.Tasks;
using EventBus.Events;

namespace Catalog.Client.API
{
    public interface IRaiseIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}