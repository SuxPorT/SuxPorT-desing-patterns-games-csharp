namespace DesignPatterns.Behavioural.Visitor.Game;

public class Boss : IGame
{
    public string? Name { get; set; }
    public int HealthPoints { get; set; }

    public void Visitor(IVisitor visitor) => visitor.Identify(this);
}
