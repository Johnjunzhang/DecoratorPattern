using DecoratorPattern;
using Xunit;

namespace DecoratorPatternTest
{
    public class BeverageTest
    {
        [Fact]
        public void should_pay_1_when_buy_espresso()
        {
           var espresso = new Espresso(false,false,false);

           Assert.Equal(4.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_5_when_buy_espresso_with_milk()
        {
            var espresso = new Espresso(true,false,false);

            Assert.Equal(5.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_9_when_buy_espresso_with_soy_and_mocha()
        {
            var espresso = new Espresso(false, true, true);

            Assert.Equal(9.0, espresso.Cost());
        }

        [Fact]
        public void should_pay_10_when_buy_espresso_with_milk_soy_mocha_and_whip()
        {
           var espresso = new Espresso(true,true,true);
       
           Assert.Equal(10.0,espresso.Cost());
        }
    }
}
