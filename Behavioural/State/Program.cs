using DesignPatterns.Behavioural.State.Characters;

namespace DesignPatterns.Behavioural.State;

public class Program
{
    public static void Main()
    {
        var context = new Context(new CharacterA());
        context.Swap();
        context.Swap();
        context.Swap();
        context.Swap();
    }
}
