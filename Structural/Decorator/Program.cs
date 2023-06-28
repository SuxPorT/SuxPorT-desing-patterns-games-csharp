using DesignPatterns.Structural.Decorator.Armors;

namespace DesignPatterns.Structural.Decorator;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Wear default armor");
        BaseArmor armor = new DefaultArmor();
        ShowArmorDescription(armor);

        Console.WriteLine("Add new itens to armor (decorate)");
        armor = new Helmet(armor);
        armor = new Sword(armor);
        ShowArmorDescription(armor);
    }

    private static void ShowArmorDescription(BaseArmor armor)
    => Console.WriteLine($"Description: {armor.Description.TrimEnd(' ', ',')}\n");
}
