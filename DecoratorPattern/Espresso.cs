namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public static Espresso CreateEspresso(bool mocha)
        {
            if (mocha)
            {
                return new MochaDecorator();
            }
            return new Espresso();
        }

        protected Espresso()
        {
        }

        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return 4.00;
        }
    }
}