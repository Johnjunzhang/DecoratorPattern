namespace DecoratorPattern
{
    public class MochaDecorator : Beverage
    {
        private Espresso espresso;

        public MochaDecorator(Espresso espresso1)
        {
            espresso = espresso1;
        }

        public override double Cost()
        {        
            return espresso.Cost()+3.0;
        }
    }
}