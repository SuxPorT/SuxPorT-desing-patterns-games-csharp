namespace DesignPatterns.Behavioural.Mediator.Players;

public class PlayerTwo : Player
{
    public PlayerTwo(AbstractMediator mediator) : base(mediator) { }

    public void Send(string message) => PlayerMediator.Send(message, this);

    public void Notify(string message)
    => Console.WriteLine($"Message from Player 2: {message}");
}
