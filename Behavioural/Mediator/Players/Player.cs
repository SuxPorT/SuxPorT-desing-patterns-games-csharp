namespace DesignPatterns.Behavioural.Mediator.Players
{
    public class Player
    {
        protected AbstractMediator PlayerMediator;

        public Player(AbstractMediator mediator) => PlayerMediator = mediator;
    }
}
