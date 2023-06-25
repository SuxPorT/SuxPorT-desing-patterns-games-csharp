namespace DesignPatterns.Behavioural.Iterator.Phases
{
    public class Aggregate : IAggregate
    {
        readonly List<string> Collection = null;

        public Aggregate() => Collection = new List<string>();

        public IIterator GetIterator() => new PhaseIterator(this);

        public string this[int indexItem]
        {
            get
            {
                if (indexItem < Collection.Count)
                    return Collection[indexItem];
                else
                    return string.Empty;
            }
            set { Collection.Add(value); }
        }

        public int Counter
        {
            get { return Collection.Count; }
        }
    }
}
