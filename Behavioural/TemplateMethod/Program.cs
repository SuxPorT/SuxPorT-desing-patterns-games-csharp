using DesignPatterns.Behavioural.TemplateMethod.Modes;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose mode race");
            Console.WriteLine("1 - Easy | 2 - Normal | 3 - Hard");
            Console.WriteLine("Your conditions are: ");

            try
            {
                var game = SetMode();
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown mode");
            }
        }

        private static Game SetMode()
        {
            return Console.ReadLine() switch
            {
                "1" => new EasyMode(),
                "2" => new NormalMode(),
                "3" => new HardMode(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
