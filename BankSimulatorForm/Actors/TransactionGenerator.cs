using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BankSimulatorForm.Actors {
    class TransactionGenerator {
        private CancellationToken cancelToken;
        private CustomerList customerList;
        private BankQueue bankQueue;
        private int maxTransAmount;
        private Task task;
        private int timeoutThrottle;
        private UIHelper uiHelper;
        private Random random = new Random();

        public TransactionGenerator(UIHelper uiHelper, CancellationToken cancelToken, BankQueue bankQueue, CustomerList customerList, int maxTransaction) {
            this.cancelToken = cancelToken;
            this.bankQueue = bankQueue;
            this.customerList = customerList;
            this.maxTransAmount = maxTransaction;
            this.uiHelper = uiHelper;

            // Random customer, random type, random amount

            task = new Task(() => {
                uiHelper.AddTransactionGeneratorStartedMessage();
                while(true) {
                    this.bankQueue.Enqueue(generateTransaction(cancelToken));
                    Thread.Sleep(1);
                }
            }, cancelToken);
            try {
                task.Start();

            } catch(OperationCanceledException) {

                uiHelper.AddTellerStoppedMessage();
            }
        }

        public Transaction generateTransaction(CancellationToken token) {
            token.ThrowIfCancellationRequested();
            Debug.Print("TransactionGenerator generateTransaction START");
            var customer = customerList.GetRandomCustomer(this.random);
            var type = random.Next(2) == 1 ? TransactionType.Deposit : TransactionType.Withdrawal;
            var amount = random.Next((maxTransAmount + 1));
            Debug.Print("TransactionGenerator generateTransaction END");
            return new Transaction(customer, amount, type);
        }
    }    
}
