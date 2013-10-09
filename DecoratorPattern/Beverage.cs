namespace DecoratorPattern
{
    public abstract class Beverage
    {
        private bool milk;

        public void SetMilk(bool value)
        {
            milk = value;
        }

        public virtual bool GetMilk()
        {
            return milk;
        }

        public bool Mocha { get; private set; }

        protected Beverage(bool milk, bool mocha)
        {
            SetMilk(milk);
            Mocha = mocha;
        }

        public virtual string GetDescription()
        {
            return "";
        }

        public abstract double Cost();
    }
}