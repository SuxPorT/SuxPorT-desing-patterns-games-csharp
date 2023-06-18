using DesignPatterns.Creational.Builder.SoldierCreators;
using DesignPatterns.Creational.Builder.Soldiers;

namespace DesignPatterns.Creational.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            SoldierCreator soldierCreator;
            Soldier soldier;

            soldierCreator = new SpecialForcesCreator();
            soldier = Army.CreateSoldier(soldierCreator).GetSoldier();
            Army.ShowSoldierDetails(soldier);

            soldierCreator = new LightInfrantryCreator();
            soldier = Army.CreateSoldier(soldierCreator).GetSoldier();
            Army.ShowSoldierDetails(soldier);
        }
    }
}
