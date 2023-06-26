namespace DesignPatterns.Behavioural.Memento.State
{
    public class ConcreteMemento
    {
        private readonly string _state;

        public string State { get { return _state; } }

        public ConcreteMemento(string state) => _state = state;
    }
}
