namespace DesignPatterns.Structural.Adapter.Actions;

public class Plane
{
    public void Fly(string player) => Console.WriteLine($"{player} flew foward");
    public void ReleaseMissle() => Console.WriteLine("Released a missle in the game");
}
