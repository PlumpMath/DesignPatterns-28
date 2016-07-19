namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Client
    {
        private readonly AbstractProductA abstractProductA;

        private readonly AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            this.abstractProductB = factory.CreateProductB();
            this.abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
        }
    }
}