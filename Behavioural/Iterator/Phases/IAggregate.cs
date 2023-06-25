namespace DesignPatterns.Behavioural.Iterator.Phases
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int indexItem] { set; get; }
        int Counter { get; }
    }
}
