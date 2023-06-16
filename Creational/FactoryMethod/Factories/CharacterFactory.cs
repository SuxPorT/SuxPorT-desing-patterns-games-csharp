using DesignPatterns.Creational.FactoryMethod.Characters;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    public class CharacterFactory
    {
        public ICharacter? ChooseCharacter(string character)
        {
            return character switch
            {
                "Liu Kang" => new LiuKang(),
                "SubZero" => new SubZero(),
                "Scorpion" => new Scorpion(),
                _ => null,
            };
        }
    }

}
