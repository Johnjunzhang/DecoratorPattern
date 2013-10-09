namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public static Espresso CreateEspresso(bool mocha)
        {
            if (mocha)
            {
                return new MochaDecorator(mocha);
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

            if (GetMocha())
            {
                condimentCost = condimentCost + 3.0;
            }

            return condimentCost;
        }
    }
}