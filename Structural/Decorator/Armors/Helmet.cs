namespace DesignPatterns.Structural.Decorator.Armors
{
    public class Helmet : DecoratorArmor
    {
        public new readonly string _description = "Helmet, ";
        private readonly BaseArmor _baseArmor;

        public Helmet(BaseArmor baseArmor) => _baseArmor = baseArmor;

        public override string Description
        {
            get { return _baseArmor.Description + _description; }
        }
    }
}
