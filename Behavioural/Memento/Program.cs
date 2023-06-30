using DesignPatterns.Behavioural.Memento.State;

namespace DesignPatterns.Behavioural.Memento;

public class Program
{
    public static void Main()
    {
        var action = new MementoAction { State = "play" };
        var store = new Store { Memento = action.CreateMemento() };

        action.State = "pause";
        action.RestoreState(store.Memento);
    }
}
