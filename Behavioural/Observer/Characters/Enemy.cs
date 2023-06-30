namespace DesignPatterns.Behavioural.Observer.Characters;

public class Enemy : IObserver
{
    private readonly Cody _observedCharacter;

    public Enemy(Cody cody)
    {
        _observedCharacter = cody;
        _observedCharacter.RegisterObserver(this);
    }

    public void Notify(ICharacter character)
    {
        if (character == _observedCharacter)
            Console.WriteLine($"Cody was hit with a punch, now his health is: " +
                $"{_observedCharacter.GetHealth()}");
    }
}
