using DesignPatterns.Behavioural.State.Characters;

namespace DesignPatterns.Behavioural.State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context(new CharacterA());
            context.Swap();
            context.Swap();
            context.Swap();
            context.Swap();
        }
    }
}
