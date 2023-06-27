namespace DesignPatterns.Creational.Builder.Soldiers;

public class LightInfrantrySoldier : Soldier
{
    public override void ChooseGun(string gun) => Gun = gun;
    public override void ChooseTransport(string transport) => Transport = transport;
    public override void DefineFocus(string focus) => Focus = focus;
}
