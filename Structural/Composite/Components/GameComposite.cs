namespace DesignPatterns.Structural.Composite.Components
{
    public class GameComposite : PhaseComponent
    {
        private List<PhaseComponent> _gamePhases = new();

        public GameComposite(string name) : base(name) { }

        public override void Add(PhaseComponent component) => _gamePhases.Add(component);
        public override void Remove(PhaseComponent component) => _gamePhases.Remove(component);

        public override void Show(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");

            foreach (var item in _gamePhases)
                item.Show(depth + 2);
        }
    }
}
