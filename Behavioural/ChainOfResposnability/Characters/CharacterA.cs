namespace DesignPatterns.Behavioural.ChainOfResposnability.Characters;

public class CharacterA : Manipulator
{
    public override void CallUp(int powerAmount)
    {
        if (powerAmount >= 0 && powerAmount < 10)
            Console.WriteLine($"{GetType().Name} called up to a force of " +
                $"{powerAmount} power amount");
        else
            successor?.CallUp(powerAmount);
    }
}
