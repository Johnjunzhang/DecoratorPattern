namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso(bool milk, bool mocha)
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

            if (Milk)
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