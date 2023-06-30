namespace DesignPatterns.Behavioural.Command.RobotControl;

public class Receiver
{
    public void FirstRequest(string request)
    => Console.WriteLine($"Received request: {request}");

    public void SecondRequest(string request)
    => Console.WriteLine($"Another command received: {request}");
}
