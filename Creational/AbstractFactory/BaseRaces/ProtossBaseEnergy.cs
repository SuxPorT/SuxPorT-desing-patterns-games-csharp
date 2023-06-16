using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.BaseRaces
{
    public class ProtossBaseEnergy : IEnergy
    {
        public void Composition()
        => Console.WriteLine("Base sustaining energy with crystals");
    }
}
