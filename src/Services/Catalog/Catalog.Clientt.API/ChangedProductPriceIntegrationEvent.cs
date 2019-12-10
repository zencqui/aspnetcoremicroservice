using EventBus.Events;

namespace Catalog.Client.API
{
    public class ChangedProductPriceIntegrationEvent : IntegrationEvent
    {
        public ChangedProductPriceIntegrationEvent(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}