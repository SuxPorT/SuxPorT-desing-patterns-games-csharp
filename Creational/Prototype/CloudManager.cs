using DesignPatterns.Creational.Prototype.Clouds;

namespace DesignPatterns.Creational.Prototype
{
    public class CloudManager
    {
        private readonly Dictionary<string, BaseCloud> clouds = new();								
		
        public BaseCloud this[string key]
        {
            get { return clouds[key]; }
            set { clouds.Add(key, value); }
        }
    }
}
