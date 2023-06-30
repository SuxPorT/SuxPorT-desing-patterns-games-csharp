namespace DesignPatterns.Behavioural.Memento.State;

public class MementoAction
{
    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Game state: {_state}");
        }
    }

    public ConcreteMemento CreateMemento() => new(_state);

    public void RestoreState(ConcreteMemento memento)
    {
        Console.WriteLine("Restoring the state...");
        State = memento.State;
    }
}
