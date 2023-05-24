using StringKataCalculator.logic;
using Xunit;
namespace StringKataCalculator.Tests
{
    public class CalculatorTester
    {
        Calculator calculator = new Calculator();
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("4,6", 10)]



        public void ShouldReturnZeroOfNullString(string _data,int expexted)
        {
            
            //Act
           

            int actual= calculator.Add(_data);

            //Assert
            Assert.Equal(expexted, actual);

        }

        [Theory]
        [InlineData("4,6,2", 12)]
        [InlineData("4,6,2,8", 20)]
        [InlineData("1,2,3,4,5,6,7,8,9", 45)]


        public void ShouldAddUknownNumbers(string _data, int expexted)
        {

            //Act


            int actual = calculator.Add(_data);

            //Assert
            Assert.Equal(expexted, actual);

        }

    }
}