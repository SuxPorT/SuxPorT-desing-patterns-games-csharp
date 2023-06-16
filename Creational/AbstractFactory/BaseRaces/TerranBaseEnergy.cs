using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.BaseRaces
{
    public class TerranBaseEnergy : IEnergy
    {
        public void Composition()
        => Console.WriteLine("Mechanical base sustaining energy");
    }
}
