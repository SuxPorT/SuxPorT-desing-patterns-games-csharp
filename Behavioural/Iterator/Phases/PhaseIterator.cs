namespace DesignPatterns.Behavioural.Iterator.Phases
{
    public class PhaseIterator : IIterator
    {
        readonly IAggregate Collection = null;
        int currentIndex = 0;

        public PhaseIterator(IAggregate collection) => Collection = collection;

        public string FirstItem
        {
            get
            {
                currentIndex = 0;
                return Collection[currentIndex];
            }
        }

        public string NextItem
        {
            get
            {
                currentIndex += 1;

                if (IsReady == false)
                    return Collection[currentIndex];
                else
                    return string.Empty;
            }
        }

        public string CurrentItem
        {
            get { return Collection[currentIndex]; }
        }

        public bool IsReady
        {
            get { return currentIndex >= Collection.Counter; }
        }
    }
}
