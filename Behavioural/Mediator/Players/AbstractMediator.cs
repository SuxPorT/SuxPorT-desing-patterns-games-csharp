namespace DesignPatterns.Behavioural.Mediator.Players
{
    public abstract class AbstractMediator
    {
        public abstract void Send(string message, Player player);
    }
}
