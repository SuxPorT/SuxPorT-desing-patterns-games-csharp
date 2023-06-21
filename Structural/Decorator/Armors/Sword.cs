namespace DesignPatterns.Structural.Decorator.Armors
{
    public class Sword : DecoratorArmor
    {
        public new readonly string _description = "Ultra strong sword, ";
        private readonly BaseArmor _baseArmor;

        public Sword(BaseArmor baseArmor) => _baseArmor = baseArmor;

        public override string Description
        {
            get { return _baseArmor.Description + _description; }
        }
    }
}
