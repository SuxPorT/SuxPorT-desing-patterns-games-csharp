namespace DesignPatterns.Behavioural.Command.RobotControl;

public class ComplexCommand : ICommand
{
    private readonly Receiver _receiver;
    private readonly string _firstRequest;
    private readonly string _secondRequest;

    public ComplexCommand(Receiver receiver, string firstRequest, string secondRequest)
    {
        _receiver = receiver;
        _firstRequest = firstRequest;
        _secondRequest = secondRequest;
    }

    public void Execute()
    {
        _receiver.FirstRequest(_firstRequest);
        _receiver.SecondRequest(_secondRequest);
    }
}
