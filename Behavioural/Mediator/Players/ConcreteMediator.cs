namespace DesignPatterns.Behavioural.Mediator.Players
{
    public class ConcreteMediator : AbstractMediator
    {
        private PlayerOne _playerOne;
        private PlayerTwo _playerTwo;

        public PlayerOne PlayerOne
        { set { _playerOne = value; } }

        public PlayerTwo PlayerTwo
        { set { _playerTwo = value; } }

        public override void Send(string message, Player player)
        {
            if (player == _playerTwo)
                _playerOne.Notify(message);
            else
                _playerTwo.Notify(message);
        }
    }
}
