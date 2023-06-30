namespace DesignPatterns.Behavioural.Command.RobotControl;

public class SimpleCommand : ICommand
{
    private readonly string _request = string.Empty;

    public SimpleCommand(string solicitacao) => _request = solicitacao;

    public void Execute()
    => Console.WriteLine($"I'm executing a simple command from {_request}");
}
