using DesignPatterns.Creational.Prototype.Clouds;

namespace DesignPatterns.Creational.Prototype;

public class Program
{
    public static void Main()
    {
        var cloudManager = new CloudManager();
        cloudManager["default"] = new ConcreteCloud("white", "blue");
        cloudManager["custom"] = new ConcreteCloud("white", "orange");

        _ = cloudManager["default"].Clone() as ConcreteCloud;
        _ = cloudManager["default"].Clone() as ConcreteCloud;
        _ = cloudManager["custom"].Clone() as ConcreteCloud;
    }
}
