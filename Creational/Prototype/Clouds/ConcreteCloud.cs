namespace DesignPatterns.Creational.Prototype.Clouds
{
    public class ConcreteCloud : BaseCloud
    {
        private readonly string FillColor, OutlineColor;

        public ConcreteCloud(string fillColor, string outlineColor)
        {
            FillColor = fillColor;
            OutlineColor = outlineColor;
        }

        public override BaseCloud Clone()
        {
            Console.WriteLine($"The cloned cloud has fill {FillColor} and outline {OutlineColor}");

            return MemberwiseClone() as BaseCloud;
        }
    }
}
