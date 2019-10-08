using System.Threading.Tasks;
using EventBus.Events;

namespace ServiceBusPublisher
{
    public interface IClientRaiseIntegrationEventService
    {
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}