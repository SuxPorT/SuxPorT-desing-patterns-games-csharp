namespace DesignPatterns.Structural.Flyweight.Turtles
{
    public class RedKoopaTroopa : KoopaTroopa
    {
        public RedKoopaTroopa()
        {
            Condition = "turtle inside the shell";
            Action = "sppining on the flor";
        }

        public override void Show(string color)
        {
            Color = color;
            Console.WriteLine($"Condition: {Condition}\nAction: {Action}\nColor: {Color.ToUpper()}");
        }
    }
}
