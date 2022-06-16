namespace demo02 {
    public class Bank {
        public BankAccount[] Accounts;// = new BankAccount[10];
        public BankAccount OpenAccount() {

            BankAccount b1 = new BankAccount();
            b1.AccountNumber = "123";
            return b1;
        }

        public decimal CalculateTotal() {
            decimal total = 0;
            foreach (BankAccount account in Accounts) {
                if (account is not null) {
                    total += account.Balance;
                }
                //if (item != null) {

                //}
            }
            return total;
        }

        public void Transfer(BankAccount source, BankAccount destination, decimal amount) {
            source.Withdraw(amount);
            destination.Deposit(amount);
        }
    }
}