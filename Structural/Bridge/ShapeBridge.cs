using DesignPatterns.Structural.Bridge.Blocks;

namespace DesignPatterns.Structural.Bridge
{
    public class ShapeBridge
    {
        public IShape Shape { get; set; }

        public void ShowShape() => Console.WriteLine(Shape.GoDown());
    }
}
