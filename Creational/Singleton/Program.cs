namespace DesignPatterns.Creational.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var playerOne = Singleton.GetInstance;
            playerOne.Message("Player 1: The ball is with me in midfield");

            var playerTwo = Singleton.GetInstance;
            playerTwo.Message("Player 2: Received the ball");

            var playerThree = Singleton.GetInstance;
            playerThree.Message("Player 3: received the launch at the bottom line");
        }
    }
}
