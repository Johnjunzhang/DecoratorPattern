namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso(bool mocha)
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