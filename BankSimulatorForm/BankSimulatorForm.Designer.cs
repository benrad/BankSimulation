namespace BankSimulatorForm {
    partial class BankSimulatorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBoxBank = new System.Windows.Forms.GroupBox();
            this.txbxInitialVaultAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxNumCustomers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxNumTellers = new System.Windows.Forms.TextBox();
            this.groupBoxTransactions = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxMaxTransaction = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.txbxInitialCustomerAmount = new System.Windows.Forms.TextBox();
            this.txbxGoal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lsbxTransactionHistory = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxBank.SuspendLayout();
            this.groupBoxTransactions.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBank
            // 
            this.groupBoxBank.Controls.Add(this.txbxInitialVaultAmount);
            this.groupBoxBank.Controls.Add(this.label3);
            this.groupBoxBank.Controls.Add(this.txbxNumCustomers);
            this.groupBoxBank.Controls.Add(this.label2);
            this.groupBoxBank.Controls.Add(this.label1);
            this.groupBoxBank.Controls.Add(this.txbxNumTellers);
            this.groupBoxBank.Location = new System.Drawing.Point(13, 13);
            this.groupBoxBank.Name = "groupBoxBank";
            this.groupBoxBank.Size = new System.Drawing.Size(292, 103);
            this.groupBoxBank.TabIndex = 0;
            this.groupBoxBank.TabStop = false;
            this.groupBoxBank.Text = "Bank";
            // 
            // txbxInitialVaultAmount
            // 
            this.txbxInitialVaultAmount.Location = new System.Drawing.Point(186, 71);
            this.txbxInitialVaultAmount.Name = "txbxInitialVaultAmount";
            this.txbxInitialVaultAmount.Size = new System.Drawing.Size(100, 20);
            this.txbxInitialVaultAmount.TabIndex = 5;
            this.txbxInitialVaultAmount.TextChanged += new System.EventHandler(this.txbxInitialVaultAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Vault Amount";
            // 
            // txbxNumCustomers
            // 
            this.txbxNumCustomers.Location = new System.Drawing.Point(186, 45);
            this.txbxNumCustomers.Name = "txbxNumCustomers";
            this.txbxNumCustomers.Size = new System.Drawing.Size(100, 20);
            this.txbxNumCustomers.TabIndex = 3;
            this.txbxNumCustomers.TextChanged += new System.EventHandler(this.txbxNumCustomers_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Tellers";
            // 
            // txbxNumTellers
            // 
            this.txbxNumTellers.Location = new System.Drawing.Point(186, 19);
            this.txbxNumTellers.Name = "txbxNumTellers";
            this.txbxNumTellers.Size = new System.Drawing.Size(100, 20);
            this.txbxNumTellers.TabIndex = 0;
            // 
            // groupBoxTransactions
            // 
            this.groupBoxTransactions.Controls.Add(this.label4);
            this.groupBoxTransactions.Controls.Add(this.txbxMaxTransaction);
            this.groupBoxTransactions.Location = new System.Drawing.Point(311, 12);
            this.groupBoxTransactions.Name = "groupBoxTransactions";
            this.groupBoxTransactions.Size = new System.Drawing.Size(327, 104);
            this.groupBoxTransactions.TabIndex = 6;
            this.groupBoxTransactions.TabStop = false;
            this.groupBoxTransactions.Text = "Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maximum Transaction Amount";
            // 
            // txbxMaxTransaction
            // 
            this.txbxMaxTransaction.Location = new System.Drawing.Point(221, 16);
            this.txbxMaxTransaction.Name = "txbxMaxTransaction";
            this.txbxMaxTransaction.Size = new System.Drawing.Size(100, 20);
            this.txbxMaxTransaction.TabIndex = 0;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.txbxInitialCustomerAmount);
            this.groupBoxCustomer.Controls.Add(this.txbxGoal);
            this.groupBoxCustomer.Controls.Add(this.label6);
            this.groupBoxCustomer.Controls.Add(this.label5);
            this.groupBoxCustomer.Location = new System.Drawing.Point(13, 123);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(625, 42);
            this.groupBoxCustomer.TabIndex = 7;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // txbxInitialCustomerAmount
            // 
            this.txbxInitialCustomerAmount.Location = new System.Drawing.Point(519, 13);
            this.txbxInitialCustomerAmount.Name = "txbxInitialCustomerAmount";
            this.txbxInitialCustomerAmount.ReadOnly = true;
            this.txbxInitialCustomerAmount.Size = new System.Drawing.Size(100, 20);
            this.txbxInitialCustomerAmount.TabIndex = 3;
            // 
            // txbxGoal
            // 
            this.txbxGoal.Location = new System.Drawing.Point(186, 13);
            this.txbxGoal.Name = "txbxGoal";
            this.txbxGoal.Size = new System.Drawing.Size(100, 20);
            this.txbxGoal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Initial Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Goal Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Transaction History";
            // 
            // lsbxTransactionHistory
            // 
            this.lsbxTransactionHistory.FormattingEnabled = true;
            this.lsbxTransactionHistory.Location = new System.Drawing.Point(23, 201);
            this.lsbxTransactionHistory.Name = "lsbxTransactionHistory";
            this.lsbxTransactionHistory.Size = new System.Drawing.Size(615, 342);
            this.lsbxTransactionHistory.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(563, 555);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(104, 555);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 555);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BankSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 590);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lsbxTransactionHistory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.groupBoxTransactions);
            this.Controls.Add(this.groupBoxBank);
            this.Name = "BankSimulatorForm";
            this.Text = "Bank Teller Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankSimulatorForm_FormClosing);
            this.groupBoxBank.ResumeLayout(false);
            this.groupBoxBank.PerformLayout();
            this.groupBoxTransactions.ResumeLayout(false);
            this.groupBoxTransactions.PerformLayout();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBank;
        private System.Windows.Forms.TextBox txbxInitialVaultAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxNumCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxNumTellers;
        private System.Windows.Forms.GroupBox groupBoxTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxMaxTransaction;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox txbxInitialCustomerAmount;
        private System.Windows.Forms.TextBox txbxGoal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lsbxTransactionHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

