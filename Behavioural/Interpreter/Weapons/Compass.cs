namespace DesignPatterns.Behavioural.Interpreter.Weapons
{
    public class Compass : ITool
    {
        public new void Interpret(Context context)
        => context.Content += $" Compass ";
    }
}
