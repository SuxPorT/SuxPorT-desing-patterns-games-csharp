namespace DesignPatterns.Structural.Facade.Subsystems
{
    public class FacadeSubsystems
    {
        private readonly SubsystemOne _subsystemOne;
        private readonly SubsystemTwo _subsystemTwo;
        private readonly SubsystemThree _subsystemThree;

        public FacadeSubsystems()
        {
            _subsystemOne = new SubsystemOne();
            _subsystemTwo = new SubsystemTwo();
            _subsystemThree = new SubsystemThree();
        }

        public void OperationA()
        {
            Console.WriteLine("Operation A");
            _subsystemOne.Responsibility();
            _subsystemTwo.Responsibility();
        }

        public void OperationB()
        {
            Console.WriteLine("Operation B");
            _subsystemThree.Responsibility();
        }
    }
}
