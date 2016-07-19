using System;

namespace DesignPatterns.StructuralPatterns.State
{
    internal class MainApp
    {
        private static void Main()
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }
}
