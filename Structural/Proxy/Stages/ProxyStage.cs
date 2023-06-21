namespace DesignPatterns.Structural.Proxy.Stages
{
    public class ProxyStage : IStage
    {
        private GameStage? _gameStage;
        private readonly string _password = "123";

        public string Play()
        => (_gameStage != null) ? 
            _gameStage.Play() : 
            "Enter the correct password to open the game stage";

        public string InformPassword(string password)
        {
            if (password == _password)
            {
                _gameStage = new GameStage();
                return "Correct password";
            }

            return "Invalid password";
        }
    }
}
