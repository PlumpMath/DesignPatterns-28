namespace DesignPatterns.StructuralPatterns.State
{
    internal abstract class State
    {
        public abstract void Handle(Context context);
    }

    internal class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    internal class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}