using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        

        BankAccount bankAccount = new BankAccount();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            

            bankAccount.customerName = customerNameTextBox.Text;
            bankAccount.accountNumber = accountNoTextBox.Text;
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            

            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isDeposited = bankAccount.Deposit(amount);
            if (isDeposited)
            {
                amountTextBox.Text = " ";
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            


            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isWithdrawn = bankAccount.Withdraw(amount);
            if (isWithdrawn)
            {
                amountTextBox.Text = " ";
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            

            string message = bankAccount.GetInfo();
            MessageBox.Show(message);
        }
    }
}
