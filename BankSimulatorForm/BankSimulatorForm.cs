using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

using BankSimulatorForm.Actors;

namespace BankSimulatorForm {
    internal enum TransactionType { Deposit, Withdrawal }
    public partial class BankSimulatorForm : Form {
        private UIHelper uiHelper;
        private BankSimulator bankSimulator;
        private SynchronizationContext syncContext;
        private bool isLoaded;
        public BankSimulatorForm() {
            InitializeComponent();
            txbxInitialCustomerAmount.Text = ConfigurationManager.AppSettings.Get("txbxInitialCustomerAmount");
            txbxNumTellers.Text = ConfigurationManager.AppSettings.Get("txbxNumTellers");
            txbxNumCustomers.Text = ConfigurationManager.AppSettings.Get("txbxNumCustomers");
            txbxInitialVaultAmount.Text = ConfigurationManager.AppSettings.Get("txbxInitialVaultAmount");
            txbxMaxTransaction.Text = ConfigurationManager.AppSettings.Get("txbxMaxTransaction");
            txbxGoal.Text = ConfigurationManager.AppSettings.Get("txbxGoal");

            syncContext = WindowsFormsSynchronizationContext.Current;
            uiHelper = new UIHelper(this, syncContext);
            isLoaded = true;
           
        }

        public void AddListBoxItem(string message) {
            lsbxTransactionHistory.Items.Add(string.Format(message));
        }

        public void AddListBoxItems(string message, string[] messages) {
            lsbxTransactionHistory.Items.Add(message);
            lsbxTransactionHistory.Items.AddRange(messages);
        }

        private bool ValidateFields() {

            try {
                Convert.ToInt32(txbxNumTellers.Text);
            } catch(FormatException) {
                MessageBox.Show("Invalid number of tellers");
                txbxNumTellers.Focus();
                return false;
            }

            try {
                Convert.ToInt32(txbxNumCustomers.Text);
            } catch(FormatException) {
                MessageBox.Show("Invalid number of customers");
                txbxNumCustomers.Focus();
                return false;
            }

            try {
                Convert.ToDecimal(txbxInitialVaultAmount.Text);
            } catch(FormatException) {
                MessageBox.Show("Invalid vault balance");
                txbxInitialVaultAmount.Focus();
                return false;
            }

            try {
                Convert.ToDecimal(txbxGoal.Text);
            } catch(FormatException) {
                MessageBox.Show("Invalid goal amount");
                txbxGoal.Focus();
                return false;
            }

            try {
                Convert.ToInt32(txbxMaxTransaction.Text);
            } catch(FormatException) {
                MessageBox.Show("Invalid max transaction value");
                txbxMaxTransaction.Focus();
                return false;
            }
            return true;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if(this.ValidateFields()) {
                bankSimulator = new BankSimulator(this.uiHelper, Convert.ToInt32(txbxNumTellers.Text), Convert.ToInt32(txbxNumCustomers.Text),
                    Convert.ToInt32(txbxMaxTransaction.Text), Convert.ToDecimal(txbxInitialCustomerAmount.Text),
                    Convert.ToDecimal(txbxInitialVaultAmount.Text), Convert.ToDecimal(txbxGoal.Text));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbxTransactionHistory.Items.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(this.bankSimulator != null) {
                bankSimulator.Stop();
            }
        }

        private void txbxNumCustomers_TextChanged(object sender, EventArgs e) {
            if(isLoaded) {
                try {
                    var ia = Convert.ToDecimal(txbxInitialVaultAmount.Text)/Convert.ToDecimal(txbxNumCustomers.Text);
                    txbxInitialCustomerAmount.Text = ia.ToString();
                } catch(FormatException ex) {
                    MessageBox.Show("Invalid input, please try again.");
                    txbxNumCustomers.Focus();
                }
            }
        }

        private void txbxInitialVaultAmount_TextChanged(object sender, EventArgs e) {
            if(isLoaded) {
                try {
                    var ia = Convert.ToDecimal(txbxInitialVaultAmount.Text)/Convert.ToDecimal(txbxNumCustomers.Text);
                    txbxInitialCustomerAmount.Text = ia.ToString();
                } catch(FormatException ex) {
                    MessageBox.Show("Invalid input, please try again.");
                    txbxInitialVaultAmount.Focus();
                }
            }
        }

        private void BankSimulatorForm_FormClosing(object sender, FormClosingEventArgs e) {
            if(this.bankSimulator != null) this.bankSimulator.Stop();
        }
    }
    
}
