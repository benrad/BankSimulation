using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using BankSimulatorForm.Actors;

namespace BankSimulatorForm {
    class Teller {
        private Bank bank;
        private CancellationToken cancelToken;
        private Task task;
        private UIHelper uiHelper;

        public Teller(UIHelper uiHelper, CancellationToken cancelToken, Bank bank) {
            this.uiHelper = uiHelper;
            this.cancelToken = cancelToken;
            this.bank = bank;

            
            task = new Task(() => {
                this.uiHelper.AddTellerStartedMessage();
                while(true) {
                    this.ProcessTransaction(bank.Queue.Dequeue(), this.cancelToken);
                }
            }, this.cancelToken);

            try {
                task.Start();
               
            } catch(OperationCanceledException) {
                                
             uiHelper.AddTellerStoppedMessage();
            }
        }

        private void ProcessTransaction(Transaction transaction, CancellationToken token) {
            // check type, withdraw from appropriate party first, end simulation if bank is bankrupt, if not then deposit, end if customer goal is met
            token.ThrowIfCancellationRequested();
            try {
                    switch(transaction.Type) {
                    //If depositing from bank to customer
                    case TransactionType.Deposit:
                        var transactionResult = bank.Vault.Withdraw(transaction.Amount);
                        //If the transaction succeeds (bank is not drained)
                        if(transactionResult.Item1) {
                            transaction.Customer.Balance += transaction.Amount;
                            transaction.Customer.AddTransaction(transaction);
                            //If the customer's goal is met
                            if(bank.CustomerGoal <= transaction.Customer.Balance) {
                                Debug.Print("Customer goal met");
                                uiHelper.AddGoalMetMessage(string.Format(
                                    "CUSTOMER GOAL ACHIEVED: {0}, {1}", transaction.Customer.Name, transaction.Customer.Balance),
                                    transaction.Customer.TransactionHistory.ToArray()); 
                                bank.BankSim.Stop();
                            }

                            uiHelper.AddCustomerTransaction(transaction, transactionResult.Item1, transactionResult.Item2);
                        } else {
                            Debug.Print("Bank is bankrupt");
                            uiHelper.AddBankOutOfFundsCustomerTransaction(transaction, transactionResult.Item2);
                            bank.BankSim.Stop();
                        }
                        break;

                    // If withdrawing from customer and depositing in bank
                    case TransactionType.Withdrawal:
                        decimal bankBalance;
                        bool success;
                        // If withdrawal amount exceeds customer's balance
                        if(transaction.Amount > transaction.Customer.Balance) {
                            success = false;
                            bankBalance = bank.Vault.Deposit(transaction.Customer.Balance);
                            transaction.Customer.Balance = 0;
                            transaction.Customer.AddTransaction(transaction);
                           
                        } else {
                            success = true;
                            transaction.Customer.Balance -= transaction.Amount;
                            bankBalance = bank.Vault.Deposit(transaction.Amount);
                            transaction.Customer.AddTransaction(transaction);
                        }
                        uiHelper.AddCustomerTransaction(transaction, success, bankBalance);
                        break;
                    }
            } catch(ThreadInterruptedException ex) {
                uiHelper.AddListBoxItem(ex.Message);
            } catch(ThreadAbortException ex) {
               uiHelper.AddListBoxItem(ex.Message);
               
            }
        }
    }
}
