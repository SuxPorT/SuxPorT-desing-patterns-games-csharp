using DesignPatterns.Behavioural.Observer.Characters;

namespace DesignPatterns.Behavioural.Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cody = new Cody();
            var enemyOne = new Enemy(cody);
            var enemyTwo = new Enemy(cody);
            var enemyThree = new Enemy(cody);

            while (true)
            {
                Console.Write("Hit Cody with a punch (Y or N) ? ");
                var hit = Console.ReadLine();
                if (hit == null)
                {
                    Console.WriteLine("Unknown choice");
                    return;
                }

                if (hit.ToLower() == "y")
                    cody.HitCharacter(true);
                else
                    Console.WriteLine("You didn't hit Cody");

                Console.WriteLine();
            }
        }
    }
}
