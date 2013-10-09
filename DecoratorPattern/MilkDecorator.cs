namespace DecoratorPattern
{
    public class MilkDecorator : Espresso
    {
        public MilkDecorator(bool milk, bool mocha) : base(milk, mocha)
        {
        }

        public override bool GetMilk()
        {
            return true;
        }
    }
}