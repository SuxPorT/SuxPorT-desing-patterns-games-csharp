namespace DesignPatterns.Structural.Decorator.Armors
{
    public class DefaultArmor : BaseArmor
    {
        public readonly string _description = "Simple protetction, ";

        public override string Description
        {
            get { return _description; }
        }
    }
}
