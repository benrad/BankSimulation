using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorForm {
    class Customer {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public bool IsAvailable { get; set; }
        private List<Transaction> _CustomerHistory = new List<Transaction>();
        public List<String> TransactionHistory {
            get {
                var retVal = new List<String>();
                foreach(Transaction transaction in _CustomerHistory) retVal.Add(transaction.ToString());
                return retVal;
            }
        }

        public Customer(string name, decimal initialBalance) {
            this.Name = name;
            this.Balance = initialBalance;
            this.IsAvailable = true;
        }

        public void AddTransaction(Transaction transaction) {
            _CustomerHistory.Add(transaction);
            Debug.Print("Customer {0} transaction processed");
            this.IsAvailable = true;
        }
    }
}
