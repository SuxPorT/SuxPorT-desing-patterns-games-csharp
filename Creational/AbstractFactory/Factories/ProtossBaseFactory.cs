using DesignPatterns.Creational.AbstractFactory.BaseRaces;
using DesignPatterns.Creational.AbstractFactory.CoatRaces;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class ProtossBaseFactory : IBaseFactory
{
    public ProtossBaseFactory() => CreateBase();

    public void CreateBase()
    {
        var coating = new ProtossBaseCoat();
        coating.Composition();

        var energy = new ProtossBaseEnergy();
        energy.Composition();

        Console.WriteLine("Protoss base successfully created!");
    }

    public void ShowRace() => Console.WriteLine("Protoss race");
}
