using DesignPatterns.Behavioural.Strategy.Boxes;

namespace DesignPatterns.Behavioural.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parrot = new Help(new Parrot());
            Console.WriteLine(parrot.ToHelp());

            var frog = new Help(new Frog());
            Console.WriteLine(frog.ToHelp());
        }
    }
}
