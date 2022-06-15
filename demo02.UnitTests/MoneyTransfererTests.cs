using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.UnitTests {
    public class MoneyTransfererTests {
        //as a user
        //I want to
        //Transfer money
        //from one BankAccount to another
        //so that
        //the saldo of the source is decreased
        //and the saldo of the target is increased

        [Fact]
        public void TransferShouldSendMoneyFromSourceToTarget() {
            //Arrange
            BankAccount source = new();
            BankAccount target = new();
            source.Deposit(100);
            target.Deposit(100);
            decimal amountToTransfer = 40;
            MoneyTransferer sut = new MoneyTransferer();

            //Act
            //???
            sut.Transfer(source, target, amountToTransfer);

            //Assert
            Assert.Equal(60,source.Saldo);
            Assert.Equal(140, target.Saldo);
        }
    }
}
