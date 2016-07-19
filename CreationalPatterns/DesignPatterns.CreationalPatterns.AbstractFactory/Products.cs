using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal abstract class AbstractProductA
    {
    }

    internal abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    internal class ProductA1 : AbstractProductA
    {
    }

    internal class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    internal class ProductA2 : AbstractProductA
    {
    }

    internal class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
