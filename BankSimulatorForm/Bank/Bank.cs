using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using BankSimulatorForm.Actors;

namespace BankSimulatorForm {
    class Bank {
        public BankVault Vault;
        public BankSimulator BankSim;
        public CustomerList Customers;
        public BankQueue Queue;
        public decimal CustomerGoal;
        private List<Teller> Tellers = new List<Teller>();

        public Bank(UIHelper uiHelper, CancellationToken cancelToken, BankSimulator bankSimulator, int numTellers, int numCustomers, decimal customerBalance, decimal bankBalance, decimal customerGoal) {
            this.CustomerGoal = customerGoal;
            this.BankSim = bankSimulator;
            // create customers in list, vault, queue, generator, tellers in list
            Customers = new CustomerList(numCustomers);
            for(int i = 0; i < numCustomers; i++) {
                Customers.AddCustomer(new Customer(String.Format("Customer{0}", i), customerBalance));
            }
            Vault = new BankVault(bankBalance);
            Queue = new BankQueue(numCustomers-1);

            for(int i = 0; i < numTellers; i++) {
                Tellers.Add(new Teller(uiHelper, cancelToken, this));
            }
        }
    }
}
