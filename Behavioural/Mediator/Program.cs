using DesignPatterns.Behavioural.Mediator.Players;

namespace DesignPatterns.Behavioural.Mediator;

public class Program
{
    public static void Main()
    {
        var mediator = new ConcreteMediator();
        var playerOne = new PlayerOne(mediator);
        var playerTwo = new PlayerTwo(mediator);

        mediator.PlayerOne = playerOne;
        mediator.PlayerTwo = playerTwo;
        playerOne.Send("This match was really good");
        playerTwo.Send("It was sensational. We got a great score");
    }
}
