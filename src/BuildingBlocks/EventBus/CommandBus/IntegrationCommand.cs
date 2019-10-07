using System;

namespace CommandBus
{
    public abstract class IntegrationCommand
    {
        protected IntegrationCommand()
        {
            Id = Guid.NewGuid();
            Sent = DateTime.UtcNow;
        }

        public abstract object GetDataAsObject();

        public Guid Id { get; }
        public DateTime Sent { get; }
    }

    public class IntegrationCommand<T> : IntegrationCommand
    {
        public IntegrationCommand(string name, T data) 
            : base()
        {
            Data = data;
            Name = name;
        }

        public T Data { get; private set; }
        public string Name { get; private set; }

        public override object GetDataAsObject() => Data;
    }
}