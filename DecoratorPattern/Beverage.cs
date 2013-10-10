namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public virtual string GetDescription()
        {
            return "";
        }

        public abstract double Cost();
    }
}