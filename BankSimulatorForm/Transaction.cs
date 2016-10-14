using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorForm {
    class Transaction {
        public decimal Amount { get; set; }
        public Customer Customer { get; set; }
        public TransactionType Type { get; set; }

        public Transaction(Customer customer, decimal amount, TransactionType type) {
            this.Amount = amount;
            this.Customer = customer;
            this.Type = type;
        }

        public override string ToString() {
            return String.Format("Type: {0}, Amount: {1}", Type, Amount);
        }
    }
}
