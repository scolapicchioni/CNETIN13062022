namespace demo02 {
    public class Bank {
        public BankAccount OpenAccount() {
            throw new NotImplementedException();
        }

        public decimal CalculateTotal() {
            throw new NotImplementedException();
        }

        public void Transfer(BankAccount source, BankAccount destination, decimal amount) {
            source.Withdraw(amount);
            destination.Deposit(amount);
        }
    }
}