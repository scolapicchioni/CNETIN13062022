namespace demo02.UnitTests {
    public class InterestCalculatorTests {
        [Theory]
        [InlineData(8,10)]
        [InlineData(4, 18)]
        public void WhenInterestIsXAmountDoublesInYYears(double interestRate, int expectedYears) {
            //Arrange (Given)
            
            InterestCalculator sut = new InterestCalculator();
            
            //Act (When)
            int actualYears = sut.CalculateYears(interestRate);
            
            //Assert (Then)
            Assert.Equal(expectedYears, actualYears);
        }

        [Fact]
        public void WhenInterestIs4AmountDoublesIn18Years() {
            //Arrange (Given)
            double interestRate = 4;
            int expectedYears = 18;

            InterestCalculator sut = new InterestCalculator();

            //Act (When)
            int actualYears = sut.CalculateYears(interestRate);

            //Assert (Then)
            Assert.Equal(expectedYears, actualYears);
        }
    }
}