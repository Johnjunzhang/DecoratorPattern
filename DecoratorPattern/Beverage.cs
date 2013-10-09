namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public bool Milk { get; private set; }
        public bool Mocha { get; private set; }

        protected Beverage(bool milk, bool mocha)
        {
            Milk = milk;
            Mocha = mocha;
        }

        public virtual string GetDescription()
        {
            return "";
        }

        public abstract double Cost();
    }
}