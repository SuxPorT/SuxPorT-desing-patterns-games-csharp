namespace DesignPatterns.Structural.Composite.Components
{
    public abstract class PhaseComponent
    {   
        protected string Name;
        public PhaseComponent(string name) => Name = name;

        public abstract void Add(PhaseComponent component);
        public abstract void Remove(PhaseComponent ccomponent);
        public abstract void Show(int depth);
    }
}
