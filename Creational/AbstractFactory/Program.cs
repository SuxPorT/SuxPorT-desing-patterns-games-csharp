using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBaseFactory factory;
            Console.WriteLine("Choose a race:\n[1] - Protoss\n[2] - Zergs\n[3] - Terran\n");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    factory = new ProtossBaseFactory();
                    break;
                case "2":
                    factory = new ZergBaseFactory();
                    break;
                case "3":
                    factory = new TerranBaseFactory();
                    break;
                default:
                    Console.WriteLine("Unknown race");
                    return;
            }

            factory.ShowRace();
        }
    }
}
