namespace DesignPatterns.Behavioural.TemplateMethod.Modes
{
    public class NormalMode : Game
    {
        public override void FirstPhase() => Console.WriteLine("The car needs to fill up once");
        public override void SecondPahse() => Console.WriteLine("Opponent cars must run in the same speed");
    }
}
