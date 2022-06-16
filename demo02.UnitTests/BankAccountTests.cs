using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.UnitTests {
    public class BankAccountTests {
        /*
         * As a user
         * I want to
         * withdraw an amount
         * from a BankAccount
         * so that 
         * the Saldo
         * is decreased
         */

        //names:
        //amount
        //BankAccount
        //Saldo

        //verbs:
        //Withdraw

        //components:
        //BankAccount

        //properties (data)
        //Saldo

        //methods (actions)
        //Withdraw
        [Fact]
        public void WithdrawShouldDecreaseSaldo() {
            //Arrange
            BankAccount sut = new BankAccount();
            sut.Deposit(110);

            decimal amountToWithdraw = 50;
            decimal expected = 60;

            //Act
            sut.Withdraw(amountToWithdraw);

            //sut.Saldo = 123;
            
            //Assert
            Assert.Equal(expected, sut.Balance);
        }

        [Fact]
        public void DepositShouldIncreaseSaldo() {
            //Arrange
            BankAccount sut = new BankAccount();
            decimal amount = 20;

            //Act
            sut.Deposit(amount);

            //Assert
            Assert.Equal(20, sut.Balance);
        }

        //[Fact]
        //public void InterestShouldNotBeSetWhenBankAccountIsNotSavings() {
        //    //Arrange
        //    BankAccount sut = new BankAccount();
        //    sut.AccountType = AccountTypes.Checking;

        //    //Act
        //    sut.Interest = 4;

        //    //Assert
        //    Assert.Equal(0, sut.Interest);

        //}

        //[Fact]
        //public void InterestShouldBeSetWhenBankAccountIsSavings() {
        //    //Arrange
        //    BankAccount sut = new BankAccount();
        //    sut.AccountType = AccountTypes.Savings;

        //    //Act
        //    sut.Interest = 4;

        //    //Assert
        //    Assert.Equal(4, sut.Interest);
        //}
    }
}
