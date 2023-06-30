using DesignPatterns.Behavioural.Visitor.Game;

namespace DesignPatterns.Behavioural.Visitor;

public class Program
{
    public static void Main()
    {
        var game = new List<IGame>
        {
            new GamePhase() { Name = "Forest" },
            new GamePhase() { Name = "Cavern" },
            new Boss()
            {
                Name = "Boss 1",
                HealthPoints = 30
            },
            new Boss()
            {
                Name = "Boss 2",
                HealthPoints = 50
            }
        };

        var levels = new VisitorLevel();
        foreach (var etapa in game)
            etapa.Visitor(levels);
    }
}
