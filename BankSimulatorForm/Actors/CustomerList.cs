using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorForm.Actors {
    class CustomerList {
        private List<Customer> Customers;

        public CustomerList(int numCustomers) {
            this.Customers = new List<Customer>(numCustomers);
        }

        public Customer GetRandomCustomer(Random random) {
//            List<Customer> availableCustomers = Customers.Where(Customer => Customer.IsAvailable).ToList();
//            var customerID = random.Next(availableCustomers.Count);
//            availableCustomers[customerID].IsAvailable = false;
//            return availableCustomers[customerID];

            var customerID = random.Next(Customers.Count);
            if(!Customers[customerID].IsAvailable) {
                Debug.Print("Customer {0} unavailable", customerID);
                return GetRandomCustomer(random);
            }
            Customers[customerID].IsAvailable = false;
            return Customers[customerID];
        }

        public void AddCustomer(Customer customer) {
            Customers.Add(customer);
        }
    }
}
