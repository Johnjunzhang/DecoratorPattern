namespace DecoratorPattern
{
    public class MilkDecorator : Beverage
    {
        private Espresso espresso;

        public MilkDecorator(bool mocha, Espresso espresso1) : base(mocha)
        {
            espresso = espresso1;
        }

        public override double Cost()
        {
            return espresso.Cost() + 1.0;
        }
    }
}