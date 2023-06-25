namespace DesignPatterns.Behavioural.Strategy.Boxes
{
    public class Help
    {
        private readonly IHelp _IHelp;

        public Help(IHelp help) => _IHelp = help;

        public string ToHelp() => _IHelp.ToHelp();
    }
}
