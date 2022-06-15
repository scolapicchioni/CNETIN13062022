namespace demo02.UnitTests {
    public class UtilitiesTests {
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 2)]
        public void GreatestShouldReturnHighestNumber(int a, int b, int expected) {
            //Arrange

            //Act
            int actual = Utilities.Greatest(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("supercalifragistuff", "hi", "supercalifragistuff")]
        [InlineData("hi", "supercalifragistuff", "supercalifragistuff")]
        public void GreatestShouldReturnLongestString(string a, string b, string expected) {
            //Arrange

            //Act
            string actual = Utilities.Greatest(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SwapShouldSwapTheArguments() {
            //Arrange
            int argument1 = 10;
            int argument2 = 5;

            //Act
            Utilities.Swap(ref argument1, ref argument2);

            //Assert
            Assert.Equal(argument1, 5);
            Assert.Equal(argument2, 10);
        }

        [Fact]
        public void FactorialShouldReturnNFactorial() {
            int n = 5;
            int expected = 120;
            
            long actual = Utilities.Factorial(n);
            
            Assert.Equal(expected, actual);
        }
    }
}
