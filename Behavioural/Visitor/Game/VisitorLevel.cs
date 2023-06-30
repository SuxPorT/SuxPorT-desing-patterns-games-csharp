namespace DesignPatterns.Behavioural.Visitor.Game;

public class VisitorLevel : IVisitor
{
    public void Identify(GamePhase phase)
    {
        switch (phase.Name)
        {
            case "Forest":
                Console.WriteLine($"Phase {phase.Name} in the game is {70}% hard");
                break;
            case "Cavern":
                Console.WriteLine($"Phase {phase.Name} in the game is {30}% hard");
                break;
            default:
                Console.WriteLine("Unknown phase");
                break;
        }
    }

    public void Identify(Boss boss)
    {
        switch (boss.Name)
        {
            case "Boss 1":
                Console.WriteLine($"The boss {boss.Name} is {25}% hard " +
                    $"and has {boss.HealthPoints} health points");
                break;
            case "Boss 2":
                Console.WriteLine($"The boss {boss.Name} is {50}% hard " +
                    $"and has {boss.HealthPoints} health points");
                break;
            default:
                Console.WriteLine("Unknown boss");
                break;
        }
    }
}
