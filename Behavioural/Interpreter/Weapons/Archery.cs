namespace DesignPatterns.Behavioural.Interpreter.Weapons;

public class Archery : IWeaponry
{
    public new void Interpret(Context context)
    => context.Content += $" Archery ";
}
