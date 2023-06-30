namespace DesignPatterns.Behavioural.Command.RobotControl;

public class Control
{
    private ICommand? simpleCommand, complexCommand;

    public void SendSimpleCommand(ICommand command)
    => simpleCommand = command;
    
    public void SendComplexCommand(ICommand command)
    => complexCommand = command;
    
    public void Execute()
    {
        Console.WriteLine("Ok, I'll execute for you");
        simpleCommand?.Execute();
        complexCommand?.Execute();
    }
}
