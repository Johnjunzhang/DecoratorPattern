namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso(bool milk, bool soy, bool mocha)
            : base(milk, soy, mocha)
        {
        }

        public override double Cost()
        {
            var condimentCost = 4.00;

            if (Milk)
            {
                condimentCost = condimentCost + 1.0;
            }
            if (Soy)
            {
                condimentCost = condimentCost + 2.0;
            }
            if (Mocha)
            {
                condimentCost = condimentCost + 3.0;
            }

            return condimentCost;
        }
    }
}