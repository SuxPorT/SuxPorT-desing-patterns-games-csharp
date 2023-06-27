using DesignPatterns.Creational.FactoryMethod.Characters;

namespace DesignPatterns.Creational.FactoryMethod.Factories;

public class CharacterFactory
{
    public ICharacter? ChooseCharacter(string character)
    => character.ToLower() switch {
        "liu kang" => new LiuKang(),
        "subzero" => new SubZero(),
        "scorpion" => new Scorpion(),
        _ => null,
    };
}
