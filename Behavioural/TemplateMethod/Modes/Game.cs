namespace DesignPatterns.Behavioural.TemplateMethod.Modes
{
    public abstract class Game
    {
        public Game()
        {
            Soundtrack();
            FirstPhase();
            SecondPahse();
        }

        public abstract void FirstPhase();
        public abstract void SecondPahse();

        private void Soundtrack() => Console.WriteLine("Emotional music");
    }
}
