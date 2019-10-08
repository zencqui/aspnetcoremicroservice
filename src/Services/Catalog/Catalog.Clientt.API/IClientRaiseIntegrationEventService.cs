using System.Threading.Tasks;
using EventBus.Events;

namespace Catalog.Clientt.API
{
    public interface IClientRaiseIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}