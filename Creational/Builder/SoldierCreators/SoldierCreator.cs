using DesignPatterns.Creational.Builder.Soldiers;

namespace DesignPatterns.Creational.Builder.SoldierCreators;

public abstract class SoldierCreator
{
    protected Soldier? _soldier;

    public abstract SoldierCreator Gun();
    public abstract SoldierCreator Transport();
    public abstract SoldierCreator Focus();
    public abstract Soldier Reset();

    public Soldier GetSoldier()
    {
        var copy = (Soldier) _soldier!.Clone();
        _soldier = Reset();

        return copy;
    }
}
