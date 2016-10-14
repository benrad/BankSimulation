using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSimulatorForm.Actors {

    class UIHelper {
        private BankSimulatorForm bankSimulatorForm;
        private SynchronizationContext syncContext;
        private delegate void SendMessage(string message);
        

        public UIHelper(BankSimulatorForm bankSimulatorForm, SynchronizationContext syncContext) {
            this.syncContext = syncContext;
            this.bankSimulatorForm = bankSimulatorForm;
            
        }
        
        public void AddTellerStoppedMessage() {
            this.AddListBoxItem(String.Format("Teller {0} stopped", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        public void AddTellerStartedMessage() {
            this.AddListBoxItem(String.Format("Teller {0} started", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        public void AddTransactionGeneratorStartedMessage() {
            this.AddListBoxItem(String.Format("TransactionGenerator {0} started", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        public void AddTransactionGeneratorStoppedMessage() {
            this.AddListBoxItem(String.Format("TransactionGenerator {0} stopped", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        public void AddCustomerTransaction(Transaction transaction, bool success, decimal bankBalance) {
            string s = success == true ? "Succeeded" : "Failed";
            String message = string.Format("{0}: Teller: {1}, Customer: {2}, Type: {3}, Amount: {4}, Customer Balance: {5}, Bank Balance: {6}",
                s, Thread.CurrentThread.ManagedThreadId, transaction.Customer.Name, transaction.Type.ToString(), transaction.Amount,
                transaction.Customer.Balance, bankBalance);
            AddListBoxItem(message);
        }

        public void AddListBoxItem(string message) {
            syncContext.Post(delegate {bankSimulatorForm.AddListBoxItem(message);}, message);
        }

        public void AddGoalMetMessage(string message, string[] history) {
            syncContext.Post(delegate {bankSimulatorForm.AddListBoxItems(message, history);}, message);
        }

        public void AddBankOutOfFundsCustomerTransaction(Transaction transaction, decimal bankBalance) {
            String m = String.Format("BANK OUT OF FUNDS: Customer: {0}, transaction amount: {1}, customer balance: {2}, bank balance: {3}",
                transaction.Customer.Name, transaction.Amount, transaction.Customer.Balance, bankBalance);
            AddListBoxItem(m);
        }
    }
}
