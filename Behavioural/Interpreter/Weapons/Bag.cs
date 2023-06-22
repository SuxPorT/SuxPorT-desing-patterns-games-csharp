namespace DesignPatterns.Behavioural.Interpreter.Weapons
{
    public class Bag : IExpression
    {
        private readonly ITool _primaryTool;
        private readonly ITool _secondaryTool;
        private readonly IWeaponry _weaponry;

        public Bag(ITool primaryTool, ITool secondaryTool, IWeaponry weaponry)
        {
            _primaryTool = primaryTool;
            _secondaryTool = secondaryTool;
            _weaponry = weaponry;
        }

        public void Interpret(Context contexto)
        {
            contexto.Content += "Opening bag...\n";

            contexto.Content += "Weaponry -";
            _weaponry.Interpret(contexto);
            contexto.Content += "\n1st tool -";
            _primaryTool.Interpret(contexto);
            contexto.Content += "\n2nd tool -";
            _secondaryTool.Interpret(contexto);

            contexto.Content += "\n... Closing bag";
            Console.WriteLine(contexto.Content);
        }
    }
}
