namespace DecoratorPattern
{
    public class MilkDecorator : Espresso
    {
        public MilkDecorator(bool mocha) : base(mocha)
        {
        }

        public override double Cost()
        {
            var condimentCost = 4.00;

            condimentCost = condimentCost + 1.0;

            if (Mocha)
            {
                condimentCost = condimentCost + 3.0;
            }

            return condimentCost;
        }
    }
}