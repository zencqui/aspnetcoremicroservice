﻿using EventBus.Events;

namespace Catalog.Clientt.API
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