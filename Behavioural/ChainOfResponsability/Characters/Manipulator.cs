namespace DesignPatterns.Behavioural.ChainOResponsability.Characters;

public abstract class Manipulator
{
    protected Manipulator? successor;

    public void DefineSuccessor(Manipulator sucessor) => successor = sucessor;
    public abstract void CallUp(int powerAmount);
}
