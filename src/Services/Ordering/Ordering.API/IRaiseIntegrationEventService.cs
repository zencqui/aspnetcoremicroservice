using System.Threading.Tasks;
using EventBus.Events;

namespace Ordering.API
{
    public interface IRaiseIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}