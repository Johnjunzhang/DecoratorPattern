namespace DecoratorPattern
{
    public class MochaDecorator:Espresso
    {
        public MochaDecorator()
        {
        }

        public override double Cost()
        {        
            return base.Cost()+3.0;
        }
    }
}