using DesignPatterns.Behavioural.Interpreter.Weapons;

namespace DesignPatterns.Behavioural.Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bag = new Bag(new Rope(), new Compass(), new Archery());
            bag.Interpret(new Context());
        }
    }
}
