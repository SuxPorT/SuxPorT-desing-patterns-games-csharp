using DesignPatterns.Structural.Proxy.Stages;

namespace DesignPatterns.Structural.Proxy;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Accessing the game stage without the Proxy");
		var stage = new GameStage();
        Console.WriteLine(stage.Play());

        Console.WriteLine("\nUsing Proxy to control game level access");
        Console.WriteLine("- Trying to access game stage with incorrect password");
        var proxy = new ProxyStage();
        InformPasswordAndPlay(proxy, "456");

        Console.WriteLine("\n- Trying to access game stage with correct password");
        InformPasswordAndPlay(proxy, "123");
    }

    private static void InformPasswordAndPlay(ProxyStage proxy, string password)
    {
        Console.WriteLine($" |-> {proxy.InformPassword(password)}");
        Console.WriteLine($" |-> {proxy.Play()}");
    }
}
