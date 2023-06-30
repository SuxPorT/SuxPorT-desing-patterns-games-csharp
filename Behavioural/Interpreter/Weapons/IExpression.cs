namespace DesignPatterns.Behavioural.Interpreter.Weapons;

public interface IExpression
{
    void Interpret(Context context);
}
