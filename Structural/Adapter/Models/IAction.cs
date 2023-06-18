namespace DesignPatterns.Structural.Adapter.Actions
{
    public interface IAction
    {
        void Walk(string player);
        void Shoot();
    }
}
