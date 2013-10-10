using DecoratorPattern;
using Xunit;

namespace DecoratorPatternTest
{
    public class BeverageTest
    {
        [Fact]
        public void should_pay_1_when_buy_espresso()
        {
            var espresso = (Beverage) Espresso.CreateEspresso(false);

           Assert.Equal(4.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_5_when_buy_espresso_with_milk()
        {
            var espresso = (Beverage) new MilkDecorator(Espresso.CreateEspresso(false));

            Assert.Equal(5.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_7_when_buy_espresso_with_mocha()
        {
            var espresso = (Beverage) Espresso.CreateEspresso(true);

            Assert.Equal(7.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_8_when_buy_espresso_with_milk_and_mocha()
        {
            var espresso = (Beverage) new MilkDecorator(Espresso.CreateEspresso(true));

            Assert.Equal(8.0, espresso.Cost());
        }

        [Fact]
        public void should_return_espresso_when_get_espresso_description()
        {
            var espresso = (Beverage) Espresso.CreateEspresso(false);

            Assert.Equal("Espresso", espresso.GetDescription());
        }
    }
}
