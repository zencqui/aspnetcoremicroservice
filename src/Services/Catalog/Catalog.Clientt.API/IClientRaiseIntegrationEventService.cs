using System.Threading.Tasks;
using EventBus.Events;

namespace Catalog.Client.API
{
    public interface IClientRaiseIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}