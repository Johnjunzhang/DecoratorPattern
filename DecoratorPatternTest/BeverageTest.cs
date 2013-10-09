using DecoratorPattern;
using Xunit;

namespace DecoratorPatternTest
{
    public class BeverageTest
    {
        [Fact]
        public void should_pay_1_when_buy_espresso()
        {
           var espresso = new Espresso(false,false);

           Assert.Equal(4.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_5_when_buy_espresso_with_milk()
        {
            var espresso = new Espresso(true,false);

            Assert.Equal(5.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_7_when_buy_espresso_with_mocha()
        {
            var espresso = new Espresso(false, true);

            Assert.Equal(7.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_8_when_buy_espresso_with_milk_and_mocha()
        {
            var espresso = new Espresso(true, true);

            Assert.Equal(8.0, espresso.Cost());
        }

        [Fact]
        public void should_return_espresso_when_get_espresso_description()
        {
            var espresso = new Espresso(false, false);

            Assert.Equal("Espresso", espresso.GetDescription());
        }
    }
}
