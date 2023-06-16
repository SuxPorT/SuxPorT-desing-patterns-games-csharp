using DesignPatterns.Creational.AbstractFactory.BaseRaces;
using DesignPatterns.Creational.AbstractFactory.CoatRaces;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class ZergBaseFactory : IBaseFactory
    {
        public ZergBaseFactory() => CreateBase();

        public void CreateBase()
        {
            var coating = new ZergBaseCoat();
            coating.Composition();

            var energy = new ZergBaseEnergy();
            energy.Composition();

            Console.WriteLine("Zerg base successfully created!");
        }

        public void ShowRace() => Console.WriteLine("Zerg race");
    }
}
