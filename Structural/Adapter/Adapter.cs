using DesignPatterns.Structural.Adapter.Actions;

namespace DesignPatterns.Structural.Adapter
{
    public class Adapter : IAction
    {
        private readonly Plane _plane;

        public Adapter(Plane plane) => _plane = plane;
        public void Walk(string player) => _plane.Fly(player);
        public void Shoot() => _plane.ReleaseMissle();
    }
}
