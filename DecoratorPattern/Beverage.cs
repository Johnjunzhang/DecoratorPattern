namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public bool Milk { get; private set; }
        public bool Soy { get; private set; }
        public bool Mocha { get; private set; }

        protected Beverage(bool milk,bool soy, bool mocha)
        {
            Milk = milk;
            Soy = soy;
            Mocha = mocha;
        }

        public abstract double Cost();
    }
}