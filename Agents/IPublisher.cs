namespace Agents
{
    public interface IPublisher<in TMessage>
    {
        void Publish(TMessage message);
    }
}