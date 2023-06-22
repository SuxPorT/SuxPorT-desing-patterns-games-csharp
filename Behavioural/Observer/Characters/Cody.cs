namespace DesignPatterns.Behavioural.Observer.Characters
{
    public class Cody : ICharacter
    {
        private List<IObserver> _enemies = new();
        public int health = 100;

        public void NotifyCharacters()
        {
            foreach (IObserver i in _enemies)
                i.Notify(this);
        }

        public void RegisterObserver(IObserver observer) => _enemies.Add(observer);

        public void HitCharacter(bool hit)
        {
            if (hit)
                health -= 10;
            NotifyCharacters();
        }

        public int GetHealth() => health;
    }
}
