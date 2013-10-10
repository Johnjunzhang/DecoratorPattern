namespace DecoratorPattern
{
    public class MochaDecorator:Espresso
    {
        public MochaDecorator()
        {
        }

        public override double Cost()
        {
            var condimentCost = 4.00;

            condimentCost = condimentCost + 3.0;
            
            return condimentCost;
        }
    }
}