using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qcrotty_Exercise6
{
    public partial class Form1 : Form
    {
        decimal initialBalance = 1362.59m;
        BankAcc bankAcc = new BankAcc();
        BankAcc.AccStatus accStatus = new BankAcc.AccStatus();

        public Form1()
        {
            InitializeComponent();

            txtAccBal.Text = initialBalance.ToString("c2");
            bankAcc.Transactions.Add(initialBalance);
            bankAcc.Balance = initialBalance;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtTransAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please input a valid format.");
            }
            else
            {
                if (rbtnDeposit.Checked)
                {
                    accStatus = bankAcc.Deposit(bankAcc.GetAccountBalance(), amount);
                    txtStatus.Text = accStatus.ToString();
                }
                if (rbtnWithdrawal.Checked)
                {
                    accStatus = bankAcc.Withdrawal(bankAcc.GetAccountBalance(), amount);
                    txtStatus.Text = accStatus.ToString();
                }
                txtAccBal.Text = bankAcc.GetAccountBalance().ToString("c2");
                txtTransAmount.Text = "";
            }
        }
        
        private void btnHistory_Click(object sender, EventArgs e)
        {
            foreach(var item in bankAcc.Transactions)
            {
                lstAccHist.Items.Insert(0, item.ToString("c2"));
            }
            bankAcc.Transactions.Clear();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bankAcc.AccountStatus(Convert.ToInt32(accStatus)));    
        }
    }
}
