using DesignPatterns.Creational.Builder.SoldierCreators;
using DesignPatterns.Creational.Builder.Soldiers;

namespace DesignPatterns.Creational.Builder
{
    public class Army
    {
        public static SoldierCreator CreateSoldier(SoldierCreator soldierCreator)
        {
            return soldierCreator.Gun()
                                 .Transport()
                                 .Focus();
        }

        public static void ShowSoldierDetails(Soldier soldier)
        {
            Console.WriteLine("Soldier details:");
            Console.WriteLine($"- Gun: {soldier.Gun}\n- Transport: {soldier.Transport}\n- Focus: {soldier.Focus}\n");
        }
    }
}
