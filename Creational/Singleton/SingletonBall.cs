namespace DesignPatterns.Creational.Singleton;

public sealed class SingletonBall
{
    private static SingletonBall? instance = null;

    public static SingletonBall GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonBall();
                Console.WriteLine("Ball in game");
            }

            return instance;
        }
    }

    public void Message(string message) => Console.WriteLine(message);
}
