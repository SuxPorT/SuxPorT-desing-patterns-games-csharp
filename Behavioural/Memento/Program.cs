using DesignPatterns.Behavioural.Memento.State;

namespace DesignPatterns.Behavioural.Memento {
    public class Program
    {
        public static void Main(string[] args)
        {
            var acao = new MementoAction
            {
                State = "play"
            };

            var store = new Store
            {
                Memento = acao.CreateMemento()
            };

            acao.State = "pause";
            acao.RestoreState(store.Memento);
        }
    }
}
