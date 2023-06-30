namespace DesignPatterns.Behavioural.ChainOResponsability.Characters;

public class CharacterC : Manipulator
{
    public override void CallUp(int powerAmount)
    {
        if (powerAmount >= 20 && powerAmount < 30)
            Console.WriteLine($"{GetType().Name} called up to a force of " +
                $"{powerAmount} power amount");
        else
            successor?.CallUp(powerAmount);
    }
}
