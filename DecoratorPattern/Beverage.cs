namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public bool Mocha { get; private set; }

        protected Beverage(bool mocha)
        {
            Mocha = mocha;
        }

        public virtual string GetDescription()
        {
            return "";
        }

        public abstract double Cost();
    }
}