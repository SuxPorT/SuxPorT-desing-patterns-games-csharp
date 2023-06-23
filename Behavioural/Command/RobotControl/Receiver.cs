namespace DesignPatterns.Behavioural.Command.RobotControl
{
    public class Receiver
    {
        public void FirstRequest(string a) => Console.WriteLine($"Received request : {a}");
        public void SecondRequest(string b) => Console.WriteLine($"Another command received: {b}");
    }
}
