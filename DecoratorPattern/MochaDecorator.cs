namespace DecoratorPattern
{
    public class MochaDecorator:Espresso
    {
        public MochaDecorator(bool mocha) : base(mocha)
        {
        }

        public override bool GetMocha()
        {
            return true;
        }
    }
}