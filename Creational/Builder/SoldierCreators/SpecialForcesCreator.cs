using DesignPatterns.Creational.Builder.Soldiers;

namespace DesignPatterns.Creational.Builder.SoldierCreators
{
    public class SpecialForcesCreator : SoldierCreator
    {
        public SpecialForcesCreator() => _soldier = new LightInfrantrySoldier();
        public override Soldier Reset() => new LightInfrantrySoldier();

        public override SpecialForcesCreator Gun()
        {
            _soldier.ChooseGun("Rifle");
            return this;
        }

        public override SpecialForcesCreator Transport()
        {
            _soldier.ChooseTransport("Special ops car");
            return this;
        }

        public override SpecialForcesCreator Focus()
        {
            _soldier.DefineFocus("Ground combat");
            return this;
        }
    }
}
