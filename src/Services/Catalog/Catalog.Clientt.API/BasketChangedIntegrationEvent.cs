using EventBus.Events;

namespace Catalog.Clientt.API
{
    public class BasketChangedIntegrationEvent : IntegrationEvent
    {
        public BasketChangedIntegrationEvent(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}