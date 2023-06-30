namespace DesignPatterns.Behavioural.ChainOfResposnability.Characters;

public class CharacterB : Manipulator
{
    public override void CallUp(int powerAmount)
    {
        if (powerAmount >= 10 && powerAmount < 20)
            Console.WriteLine($"{GetType().Name} called up to a force of " +
                $"{powerAmount} power amount");
        else
            successor?.CallUp(powerAmount);
    }
}
