namespace Agents.ServiceLocators
{
    public interface IResolver
    {
        bool CanResolve(ResolveContext context);
        object Resolve(ResolveContext context);
    }
}