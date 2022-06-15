namespace demo02 {
    public class MoneyTransferer {
        public void Transfer(BankAccount source, BankAccount target, decimal amountToTransfer) {
            source.Withdraw(amountToTransfer);
            target.Deposit(amountToTransfer);
        }
    }
}