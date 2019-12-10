using EventBus.Events;

namespace Basket.Client.API
{
    public class UserAddressChangedIntegrationEvent : IntegrationEvent
    {
        public UserAddressChangedIntegrationEvent(string message)
        {
            Message = message;

        }

        public string Message { get; private set; }
    }
}