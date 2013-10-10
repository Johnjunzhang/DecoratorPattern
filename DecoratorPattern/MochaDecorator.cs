namespace DecoratorPattern
{
    public class MochaDecorator : Beverage
    {
        private Espresso espresso;

        public MochaDecorator()
        {
            espresso = new Espresso();
        }

        public override double Cost()
        {        
            return espresso.Cost()+3.0;
        }
    }
}