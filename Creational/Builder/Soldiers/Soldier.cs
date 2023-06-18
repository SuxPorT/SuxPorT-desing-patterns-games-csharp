namespace DesignPatterns.Creational.Builder.Soldiers
{
    public abstract class Soldier
    {
        public string? Gun { get; protected set; }
        public string? Transport { get; protected set; }
        public string? Focus { get; protected set; }
        public abstract void ChooseGun(string gun);
        public abstract void ChooseTransport(string transport);
        public abstract void DefineFocus(string focus);

        public object Clone() => MemberwiseClone();
    }
}
