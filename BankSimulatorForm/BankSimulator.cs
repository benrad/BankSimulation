using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using BankSimulatorForm.Actors;

namespace BankSimulatorForm {

    class BankSimulator {
        private Bank bank;
        private readonly CancellationTokenSource CtSource = new CancellationTokenSource();
        private TransactionGenerator transactionGenerator;

        public BankSimulator(UIHelper uiHelper, int numTellers, int numCustomers, int maxTransaction,
            decimal customerBalance, decimal bankBalance, decimal customerGoal) {

           
                bank = new Bank(uiHelper, CtSource.Token, this, numTellers, numCustomers, customerBalance, bankBalance, customerGoal);
                transactionGenerator = new TransactionGenerator(uiHelper, CtSource.Token, bank.Queue, bank.Customers, maxTransaction);
         
        }

        public void Stop() {
            Debug.Print("Simulation stopped by {0}", Thread.CurrentThread.ManagedThreadId);
            CtSource.Cancel();
        }
    }
}
