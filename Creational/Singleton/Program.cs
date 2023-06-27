namespace DesignPatterns.Creational.Singleton;

public class Program
{
    public static void Main()
    {
        var playerOne = SingletonBall.GetInstance;
        playerOne.Message("Player 1: The ball is with me in midfield");

        var playerTwo = SingletonBall.GetInstance;
        playerTwo.Message("Player 2: Received the ball");

        var playerThree = SingletonBall.GetInstance;
        playerThree.Message("Player 3: received the launch at the bottom line");
    }
}
