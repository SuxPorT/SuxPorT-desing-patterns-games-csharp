namespace DesignPatterns.Behavioural.Observer.Characters
{
    public interface ICharacter
    {
        void RegisterObserver(IObserver observer);
        void NotifyCharacters();
    }
}
