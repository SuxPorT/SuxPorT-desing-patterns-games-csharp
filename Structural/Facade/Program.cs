using DesignPatterns.Structural.Facade.Subsystems;

namespace DesignPatterns.Structural.Facade;

public class Program
{
    public static void Main()
    {
        var facade = new FacadeSubsystems();
        facade.OperationA();
        Console.WriteLine();
        facade.OperationB();
    }
}
