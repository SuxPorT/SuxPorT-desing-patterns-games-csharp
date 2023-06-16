using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.CoatRaces
{
    public class TerranBaseCoat : ICoating
    {
        public void Composition()
        => Console.WriteLine("Coated base by green color");
    }
}
