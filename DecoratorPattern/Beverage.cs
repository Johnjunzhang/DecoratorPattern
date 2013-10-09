namespace DecoratorPattern
{
    public abstract class Beverage
    {
        private bool mocha;

        public void SetMocha(bool value)
        {
            mocha = value;
        }

        public virtual bool GetMocha()
        {
            return mocha;
        }

        protected Beverage(bool mocha)
        {
            SetMocha(mocha);
        }

        public virtual string GetDescription()
        {
            return "";
        }

        public abstract double Cost();
    }
}