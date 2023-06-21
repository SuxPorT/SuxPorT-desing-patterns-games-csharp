namespace DesignPatterns.Structural.Decorator.Armors
{
    public class DecoratorArmor : BaseArmor
    {
        public readonly string _description = "Character armor abstract decorator";

        public override string Description
        {
            get { return _description; }
        }
    }
}
