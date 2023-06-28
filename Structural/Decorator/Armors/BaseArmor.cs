namespace DesignPatterns.Structural.Decorator.Armors;

public abstract class BaseArmor
{
    private readonly string _description = "Abstract character armor";
		
    public virtual string Description { get { return _description; } }
}
