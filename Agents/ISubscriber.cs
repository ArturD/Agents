using System;

namespace Agents
{
    public interface ISubscriber<out TMessage>
    {
        IDisposable Subscribe(Action<TMessage> consumer);
        IDisposable Subscribe(IScheduler scheduler, Action<TMessage> consumeAction);
    }
}