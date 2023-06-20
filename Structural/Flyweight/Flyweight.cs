using DesignPatterns.Structural.Flyweight.Turtles;

namespace DesignPatterns.Structural.Flyweight
{
    public class Flyweight
    {
        private Dictionary<string, KoopaTroopa> turtlesList = new();

        public KoopaTroopa GetTurtle(string color)
        {
            KoopaTroopa? turtle;
            if (turtlesList.ContainsKey(color))
                turtle = turtlesList[color];
            else
            {
                turtle = color.ToLower() switch
                {
                    "blue" => new BlueKoopaTroopa(),
                    "green" => new GreenKoopaTroopa(),
                    "orange" => new OrangeKoopaTroopa(),
                    "red" => new RedKoopaTroopa(),
                    _ => null,
                };
                turtlesList.Add(color, turtle!);
            }

            return turtle;
        }
    }
}
