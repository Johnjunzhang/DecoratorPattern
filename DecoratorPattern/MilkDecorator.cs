namespace DecoratorPattern
{
    public class MilkDecorator : Beverage
    {
        private Espresso espresso;

        public MilkDecorator(Espresso espresso1)
        {
            espresso = espresso1;
        }

        public override double Cost()
        {
            return espresso.Cost() + 1.0;
        }
    }
}