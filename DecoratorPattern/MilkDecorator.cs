namespace DecoratorPattern
{
    public class MilkDecorator : Beverage
    {
        private Beverage espresso;

        public MilkDecorator(Beverage espresso1)
        {
            espresso = espresso1;
        }

        public override double Cost()
        {
            return espresso.Cost() + 1.0;
        }
    }
}