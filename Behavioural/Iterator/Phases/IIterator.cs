namespace DesignPatterns.Behavioural.Iterator.Phases;

public interface IIterator
{
    string FirstItem { get; }
    string NextItem { get; }
    string CurrentItem { get; }
    bool IsReady { get; }
}
