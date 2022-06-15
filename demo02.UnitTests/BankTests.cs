namespace demo02.UnitTests; 
public class BankTests {
    [Fact]
    public void GivenABankWithAccounts_TotalShouldReturnTheSumOfAllBalances() { 
        //Arrange
        BankAccount bankAccount2 = new BankAccount();
        bankAccount2.Deposit(100);

        Bank sut = new Bank();
        BankAccount b1 = sut.OpenAccount();
        b1.Deposit(100);
        BankAccount b2 = sut.OpenAccount();
        b1.Deposit(100);

        decimal expected = 200;
        //Act
        decimal actual = sut.CalculateTotal();

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void OpenAccountShouldReturnAnAccount() { 
        
    }


}
