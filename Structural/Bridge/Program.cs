using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Bridge.Blocks;
using DesignPatterns.Structural.Bridge.Colors;

namespace DesignPatterns.Structural.Brdige
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bridge = new ShapeBridge();
            var random = new Random();
            Console.WriteLine("Press ENTER to send a shape");

            while (true)
            {
                var input = Console.ReadKey();
                if (input.KeyChar == 13)
                    Sort(random, bridge);

                Console.WriteLine();
                bridge.ShowShape();
            }
        }

        public static void Sort(Random random, ShapeBridge bridge)
        {
            if (random.Next(2) == 1)
                bridge.Shape = new TBlock();
            else
                bridge.Shape = new UBlock();

            if (random.Next(1, 3) == 1)
                bridge.Shape.IColor = new Green();
            else if (random.Next(1, 3) == 2)
                bridge.Shape.IColor = new Orange();
            else
                bridge.Shape.IColor = new Pink();
        }
    }
}
