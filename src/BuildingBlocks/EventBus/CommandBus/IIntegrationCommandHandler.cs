namespace CommandBus
{
    public interface IIntegrationCommandHandler
    {
        void Handle(IIntegrationCommandHandler command);
    }

    public interface IIntegrationCommandHandler<T> : IIntegrationCommandHandler
    {
        void Handle(IIntegrationCommandHandler<T> command);
    }
}