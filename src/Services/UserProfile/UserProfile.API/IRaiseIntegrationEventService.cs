using System.Threading.Tasks;
using EventBus.Events;

namespace UserProfile.API
{
    public interface IRaiseIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}