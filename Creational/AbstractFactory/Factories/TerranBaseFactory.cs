using DesignPatterns.Creational.AbstractFactory.BaseRaces;
using DesignPatterns.Creational.AbstractFactory.CoatRaces;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class TerranBaseFactory : IBaseFactory
{
    public TerranBaseFactory() => CreateBase();

    public void CreateBase()
    {
        var coating = new TerranBaseCoat();
        coating.Composition();

        var energy = new TerranBaseEnergy();
        energy.Composition();

        Console.WriteLine("Terran base successfully created!");
    }

    public void ShowRace() => Console.WriteLine("Terran race");
}
