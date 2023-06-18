namespace DesignPatterns.Structural.Adapter.Actions
{
    public class Character : IAction
    {
        public void Shoot() => Console.WriteLine("Shot in the game");
        public void Walk(string player) => Console.WriteLine($"{player} walked foward");
    }
}
