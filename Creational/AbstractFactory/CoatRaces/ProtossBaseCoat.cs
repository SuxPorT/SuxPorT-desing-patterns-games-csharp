using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.CoatRaces
{
    public class ProtossBaseCoat : ICoating 
    {
        public void Composition()
        => Console.WriteLine("Coated base by yellow color");
    }
}
