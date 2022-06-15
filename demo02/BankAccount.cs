using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02 {
    public class BankAccount {
        //private decimal Saldo;

        //public decimal GetSaldo() {
        //    return Saldo;
        //}

        //public void SetSaldo(decimal value) {
        //    Saldo = value;
        //}

        private decimal saldo; //backing field
        public decimal Saldo { //property
            get { return saldo; }
            private set { saldo = value; }
        }
        //public decimal GetSaldo() {
        //    return Saldo;
        //}

        //public void SetSaldo(decimal value) {
        //    saldo = value;
        //}

        public void Withdraw(decimal amount) {
            this.Saldo -= amount; 
        }

        public void Deposit(decimal amount) {
            this.Saldo += amount;
        }

    }
}
