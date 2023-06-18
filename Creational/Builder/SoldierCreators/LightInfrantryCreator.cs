using DesignPatterns.Creational.Builder.Soldiers;

namespace DesignPatterns.Creational.Builder.SoldierCreators
{
    public class LightInfrantryCreator : SoldierCreator
    {
        public LightInfrantryCreator() => _soldier = new LightInfrantrySoldier();
        public override Soldier Reset() => new LightInfrantrySoldier();

        public override LightInfrantryCreator Gun()
        {
            _soldier.ChooseGun("Air strike");
            return this;
        }

        public override LightInfrantryCreator Transport()
        {
            _soldier.ChooseTransport("Army attack helicopter");
            return this;
        }

        public override LightInfrantryCreator Focus()
        {
            _soldier.DefineFocus("Air rapid response");
            return this;
        }
    }
}
