using DesignPatterns.Behavioural.TemplateMethod.Modes;

namespace DesignPatterns.Behavioural.TemplateMethod;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose mode race");
        Console.WriteLine("1 - Easy | 2 - Normal | 3 - Hard");
        Console.WriteLine("\nYour conditions are: ");

        try
        {
            var game = SetMode();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static Game SetMode()
    {
        return Console.ReadLine() switch
        {
            "1" => new EasyMode(),
            "2" => new NormalMode(),
            "3" => new HardMode(),
            _ => throw new Exception("Unknown mode"),
        };
    }
}
