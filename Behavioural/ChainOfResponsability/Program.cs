using DesignPatterns.Behavioural.ChainOResponsability.Characters;

namespace DesignPatterns.Behavioural.ChainOResponsability;

public class Program
{
    public static void Main()
    {
        Manipulator characterA = new CharacterA();
        Manipulator characterB = new CharacterB();
        Manipulator characterC = new CharacterC();

        characterA.DefineSuccessor(characterB);
        characterB.DefineSuccessor(characterC);

        var requests = new int[]{ 5, 8, 15, 20, 18, 3, 27, 20 };
        foreach (var req in requests)
            characterA.CallUp(req);
    }
}
