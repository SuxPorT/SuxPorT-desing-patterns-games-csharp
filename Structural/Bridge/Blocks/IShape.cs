using DesignPatterns.Structural.Bridge.Colors;

namespace DesignPatterns.Structural.Bridge.Blocks;

public interface IShape
{
    string GoDown();
    IColor IColor { get; set; }
}
