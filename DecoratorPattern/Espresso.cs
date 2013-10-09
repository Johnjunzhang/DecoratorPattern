namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public static Espresso CreateEspresso(bool milk, bool mocha)
        {
            if (milk)
            {
                return new MilkDecorator(milk,mocha);
            }
            return new Espresso(milk, mocha);
        }

        protected Espresso(bool milk, bool mocha)
            : base(milk,mocha)
        {
        }

        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            var condimentCost = 4.00;

            if (GetMilk())
            {
                condimentCost = condimentCost + 1.0;
            }

            if (Mocha)
            {
                condimentCost = condimentCost + 3.0;
            }

            return condimentCost;
        }
    }
}