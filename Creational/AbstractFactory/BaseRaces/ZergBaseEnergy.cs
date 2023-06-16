using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.BaseRaces
{
    public class ZergBaseEnergy : IEnergy
    {
        public void Composition()
        => Console.WriteLine("Base sustaining energy by earth");
    }
}
