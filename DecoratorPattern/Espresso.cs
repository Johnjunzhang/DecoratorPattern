namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public static Espresso CreateEspresso(bool milk, bool mocha)
        {
            if (milk)
            {
                return new MilkDecorator(mocha);
            }
            return new Espresso(mocha);
        }

        protected Espresso(bool mocha)
            : base(mocha)
        {
        }

        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            var condimentCost = 4.00;

            if (Mocha)
            {
                condimentCost = condimentCost + 3.0;
            }

            return condimentCost;
        }
    }
}