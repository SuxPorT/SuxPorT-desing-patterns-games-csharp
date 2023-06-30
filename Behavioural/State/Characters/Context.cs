namespace DesignPatterns.Behavioural.State.Characters;

public class Context
{
    private AbstractState _state;

    public Context(AbstractState state) => _state = state;

    public AbstractState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Now the behavior is: {_state.GetType().Name}" );
        }
    }

    public void Swap() => _state.Action(this);
}
