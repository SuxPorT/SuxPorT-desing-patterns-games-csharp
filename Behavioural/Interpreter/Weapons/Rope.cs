namespace DesignPatterns.Behavioural.Interpreter.Weapons
{
    public class Rope : ITool
    {
        public new void Interpret(Context context)
        => context.Content += $" Rope ";
    }
}
