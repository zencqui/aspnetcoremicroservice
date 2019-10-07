using System;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Logging;

namespace EventBusServiceBus
{
    public class DefaultServiceBusPersisterConnection : IServiceBusPersisterConnection
    {
        private readonly ServiceBusConnectionStringBuilder _serviceBusConnectionStringBuilder;
        private readonly ILogger _logger;
        private TopicClient _topicClient;
        private bool _disposed;

        public DefaultServiceBusPersisterConnection(ServiceBusConnectionStringBuilder serviceBusConnectionStringBuilder, ILogger logger)
        {
            _serviceBusConnectionStringBuilder = serviceBusConnectionStringBuilder ??
                                                 throw new ArgumentException(nameof(serviceBusConnectionStringBuilder));
            _logger = logger ?? throw new ArgumentException(nameof(logger));
            _topicClient = new TopicClient(_serviceBusConnectionStringBuilder, RetryPolicy.Default);
        }

        public ServiceBusConnectionStringBuilder ServiceBusConnectionStringBuilder =>
            _serviceBusConnectionStringBuilder;

        public ITopicClient CreateModel()
        {
            if (_topicClient.IsClosedOrClosing)
            {
                _topicClient = new TopicClient(_serviceBusConnectionStringBuilder);
            }

            return _topicClient;
        }

        public void Dispose()
        {
            if (_disposed) return;

            _disposed = true;
        }
    }
}