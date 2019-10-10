using EventBus.Events;

namespace Basket.Client.API
{
    public class ClientMessageIntegrationEvent : IntegrationEvent
    {
        public ClientMessageIntegrationEvent(string message)
        {
            Message = message;

        }

        public string Message { get; private set; }
    }
}