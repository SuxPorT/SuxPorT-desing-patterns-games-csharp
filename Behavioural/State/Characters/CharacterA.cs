namespace DesignPatterns.Behavioural.State.Characters
{
    public class CharacterA : AbstractState
    {
        public override void Action(Context context)
        => context.State = new CharacterB();
    }
}
