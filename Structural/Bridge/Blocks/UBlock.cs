using DesignPatterns.Structural.Bridge.Colors;

namespace DesignPatterns.Structural.Bridge.Blocks
{
    public class UBlock : IShape
    {
        public IColor IColor { get; set; }

        public string GoDown()
        {
            return $"U - {IColor.Color()}";
        }
    }
}
