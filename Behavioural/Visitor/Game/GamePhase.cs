namespace DesignPatterns.Behavioural.Visitor.Game;

public class GamePhase : IGame
{
    public string? Name { get; set; }

    public void Visitor(IVisitor visitor) => visitor.Identify(this);
}
