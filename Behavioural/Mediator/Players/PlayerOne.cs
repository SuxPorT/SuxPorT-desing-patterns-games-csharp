namespace DesignPatterns.Behavioural.Mediator.Players
{
    public class PlayerOne : Player
    {
        public PlayerOne(AbstractMediator mediator) : base(mediator) { }

        public void Send(string message) => PlayerMediator.Send(message, this);

        public void Notify(string message)
        => Console.WriteLine($"Message from Player 1: {message}");
    }
}
