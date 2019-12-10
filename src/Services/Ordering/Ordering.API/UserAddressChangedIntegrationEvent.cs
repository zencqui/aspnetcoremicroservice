using EventBus.Events;

namespace Ordering.API
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