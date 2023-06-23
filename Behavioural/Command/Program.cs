using DesignPatterns.Behavioural.Command.RobotControl;

namespace DesignPatterns.Behavioural.Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var control = new Control();
            control.SendSimpleCommand(new SimpleCommand("Say hi"));

            var receiver = new Receiver();
            control.SendComplexCommand(new ComplexCommand(receiver, "Fuel the car", "Calibrate car tires"));
            control.Execute();
        }
    }
}
