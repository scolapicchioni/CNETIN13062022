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
    }
}
