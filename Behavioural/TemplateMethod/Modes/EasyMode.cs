namespace DesignPatterns.Behavioural.TemplateMethod.Modes;

public class EasyMode : Game
{
    public override void FirstPhase()
    => Console.WriteLine("Fuel for the whole race");
    
    public override void SecondPahse()
    => Console.WriteLine("Opponent cars must run less");
}
