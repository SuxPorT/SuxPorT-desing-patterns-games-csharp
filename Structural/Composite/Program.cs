using DesignPatterns.Structural.Composite.Components;

namespace DesignPatterns.Structural.Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var map = new GameComposite("Caverns Map");
            var cavernOne = new GameComposite("Cavern 1");

            cavernOne.Add(new GamePhase("Sub Phase 1"));
            cavernOne.Add(new GamePhase("Sub Phase 2"));
            cavernOne.Add(new GamePhase("Sub Phase 3"));

            var cavernTwo = new GameComposite("Cavern 2");
            cavernTwo.Add(new GamePhase("Sub Phase 4"));
            cavernTwo.Add(new GamePhase("Sub Phase 5"));

            var secretPort = new GameComposite("Secret Port");
            secretPort.Add(new GamePhase("Sub Secret Phase X"));

            map.Add(cavernOne);
            map.Add(cavernTwo);
            cavernTwo.Add(secretPort);
            map.Show(1);
        }
    }
}
