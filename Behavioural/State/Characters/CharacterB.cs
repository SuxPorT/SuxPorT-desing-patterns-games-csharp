namespace DesignPatterns.Behavioural.State.Characters
{
    public class CharacterB : AbstractState
    {
        public override void Action(Context context)
        => context.State = new CharacterA();
    }
}
