using Kondital;

namespace Kondital_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAfMetoder()
        {
            //arrange
            Kondital.Kondital kondital = new(); //meget rodet klasse når man kalder den det samme...
            double vægt = 65;
            int hvilePuls = 70;
            int maxPuls = 200;
            double expected_kondital = 44;
            double expected_iltoptagelse = 2.8;
            //act
            double actual_kondital = Kondital.Kondital.BeregnKondital(hvilePuls, maxPuls);
            double actual_iltoptagelse = Math.Round(Kondital.Kondital.BeregnIltoptagelse(actual_kondital, vægt),1);
            //assert
            //fandt en måde at få begger beskeder, tænker det er en bedre måde siden at jeg alligevel skal bruge en af værdierne til at beregne den anden
            Assert.Multiple(
                () => Assert.Equal(expected_kondital, actual_kondital, 0),
                () => Assert.Equal(expected_iltoptagelse, actual_iltoptagelse, 0)
            );


        }
    }
}
