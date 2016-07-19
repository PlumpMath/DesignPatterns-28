namespace DesignPatterns.StructuralPatterns.State
{
    using System;

    internal class Context
    {
        private State state;

        public Context(State state)
        {
            this.State = state;
        }

        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
                Console.WriteLine("State: " + this.state.GetType().Name);
            }
        }

        public void Request()
        {
            this.state.Handle(this);
        }
    }
}