using DesignPatterns.Structural.Bridge.Colors;

namespace DesignPatterns.Structural.Bridge.Blocks
{
    public class TBlock : IShape
    {
        public IColor IColor { get; set; }

        public string GoDown()
        {
            return $"T - {IColor.Color()}";
        }
    }
}
