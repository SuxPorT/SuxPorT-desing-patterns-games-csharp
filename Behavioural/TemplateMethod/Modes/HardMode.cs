namespace DesignPatterns.Behavioural.TemplateMethod.Modes
{
    public class HardMode : Game
    {
        public override void FirstPhase() => Console.WriteLine("Add obstacle on the race track");
        public override void SecondPahse() => Console.WriteLine("Opponent cars must run more");
    }
}
