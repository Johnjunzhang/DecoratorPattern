namespace DecoratorPattern
{
    public class MilkDecorator : Espresso
    {
        public MilkDecorator(bool mocha) : base(mocha)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 1.0;
        }
    }
}