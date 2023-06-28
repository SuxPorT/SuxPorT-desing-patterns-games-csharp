using DesignPatterns.Structural.Flyweight.Turtles;

namespace DesignPatterns.Structural.Flyweight;

public class Program
{
    public static void Main()
    {
        var flyweight = new TurtleFlyweight();
        KoopaTroopa turtle;

        while (true)
        {
            Console.Write("Write a color: ");
            var color = Console.ReadLine();

            try
            {
                turtle = flyweight.GetTurtle(color!);
                turtle.Show(color!);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
