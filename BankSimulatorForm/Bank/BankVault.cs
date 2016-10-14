using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorForm {
    class BankVault {
        private readonly Object BankLock = new object();
        private decimal BankBalance;

        public BankVault(decimal balance) {
            this.BankBalance = balance;
        }

        public decimal Deposit(decimal amount) {
            lock(BankLock) {
                BankBalance += amount;
                return BankBalance;
            }
        }

        public Tuple<bool, decimal> Withdraw(decimal amount) {
            //Returns tuple with success/failure as first element and balance after withdrawal if success or balance before withdrawal if failure as second element.
            lock(BankLock) {
                var success = false;
                if(amount < BankBalance) {
                    BankBalance -= amount;
                    success = true;
                } 
                return new Tuple<bool, decimal>(success, BankBalance);
            }
        }
    }
}
