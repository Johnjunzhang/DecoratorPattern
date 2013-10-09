namespace DecoratorPattern
{
    public class MilkDecorator : Beverage
    {
        private Espresso espresso;

        public MilkDecorator(bool mocha) : base(mocha)
        {
            espresso = new Espresso(mocha);
        }

        public override double Cost()
        {
            return espresso.Cost() + 1.0;
        }
    }
}