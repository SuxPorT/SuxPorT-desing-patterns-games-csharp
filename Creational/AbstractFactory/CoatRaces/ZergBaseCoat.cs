using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.CoatRaces
{
    public class ZergBaseCoat : ICoating
    {
        public void Composition()
        => Console.WriteLine("Coated base by red color");
    }
}
