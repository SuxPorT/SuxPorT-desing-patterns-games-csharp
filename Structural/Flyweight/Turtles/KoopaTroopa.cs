namespace DesignPatterns.Structural.Flyweight.Turtles
{
    public abstract class KoopaTroopa
    {
        protected string? Condition, Action;
        public string? Color { get; set; }

        public abstract void Show(string color);
    }
}
