namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton
    {
        private static Singleton? instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Ball in game");
                }

                return instance;
            }
        }

        public void Message(string message) => Console.WriteLine(message);
    }
}
