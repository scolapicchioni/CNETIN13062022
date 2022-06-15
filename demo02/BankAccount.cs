using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02 {
    public class BankAccount {
        private string accountNumber = string.Empty;
        public string AccountNumber {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        //private decimal Saldo;

        //public decimal GetSaldo() {
        //    return Saldo;
        //}

        //public void SetSaldo(decimal value) {
        //    Saldo = value;
        //}

        private decimal balance; //backing field
        public decimal Balance { //property
            get { return balance; }
            private set { balance = value; }
        }
        //public decimal GetSaldo() {
        //    return Saldo;
        //}

        //public void SetSaldo(decimal value) {
        //    saldo = value;
        //}

        public void Withdraw(decimal amount) {
            this.Balance -= amount; 
        }

        public void Deposit(decimal amount) {
            this.Balance += amount;
        }

    }
}
