namespace demo02.UnitTests; 
public class BankTests {
    [Theory]
    [InlineData(100,200,300)]
    [InlineData(200, 100, 300)]
    public void GivenABankWithAccounts_TotalShouldReturnTheSumOfAllBalances(decimal firstBalance, decimal secondBalance, decimal expected) { 
        //Arrange
        Bank sut = new Bank();
        BankAccount b1 = new BankAccount();
        b1.Deposit(firstBalance);
        BankAccount b2 = new BankAccount();
        b2.Deposit(secondBalance);

        sut.Accounts[0] = b1;
        sut.Accounts[1] = b2;

        //Act
        decimal actual = sut.CalculateTotal();

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void OpenAccountShouldReturnAnAccount() { 
        
    }

    [Fact]
    public void TransferShouldSendMoneyFromSourceToDestination() {
        //Arrange
        BankAccount source = new BankAccount();
        BankAccount destination = new BankAccount();
        decimal amount = 100;

        Bank sut = new Bank();

        //Act
        sut.Transfer(source,destination, amount);

        //Assert
        Assert.Equal(100, destination.Balance);
        Assert.Equal(-100, source.Balance);
    }
}
