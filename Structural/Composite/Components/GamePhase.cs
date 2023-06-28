namespace DesignPatterns.Structural.Composite.Components;

public class GamePhase : PhaseComponent
{
    public GamePhase(string name) : base(name) { }

    public override void Add(PhaseComponent component)
    => Console.WriteLine("It is not possible to add the phase in the game from here!");

    public override void Remove(PhaseComponent component)
    => Console.WriteLine("It is not possible to remove the phase in the game from here!");

    public override void Show(int depth)
    => Console.WriteLine($"{new string('-', depth)} {Name}");
}
