using BankAccountApp;
using System;
using System.Windows.Forms;

namespace WinBankID
{
    public partial class Form1 : Form
    {
        private BankAccount bankAccount;

        public Form1()
        {
            InitializeComponent();
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string accountNumber = txtAccountNumber.Text;
                double initialBalance = Convert.ToDouble(txtInitialBalance.Text);

                bankAccount = new BankAccount(accountNumber, initialBalance);

                MessageBox.Show("Рахунок успішно створено.");
                UpdateAccountInfo();
                UpdateTransactionHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeposit_Click_Click(object sender, EventArgs e)
        {
            try
            {
                if (bankAccount == null)
                {
                    MessageBox.Show("Будь ласка, створіть рахунок перед виконанням операцій.");
                    return;
                }

                double amount = Convert.ToDouble(txtAmount.Text);
                bankAccount.Deposit(amount);
                MessageBox.Show("Баланс успішно поповнено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateAccountInfo();
            UpdateTransactionHistory();
        }

        private void btnWithdraw_Click_Click(object sender, EventArgs e)
        {
            try
            {
                if (bankAccount == null)
                {
                    MessageBox.Show("Будь ласка, створіть рахунок перед виконанням операцій.");
                    return;
                }

                double amount = Convert.ToDouble(txtAmount.Text);
                bankAccount.Withdraw(amount);
                MessageBox.Show("Гроші успішно знято.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateAccountInfo();
            UpdateTransactionHistory();
        }
        private void UpdateAccountInfo()
        {
            if (bankAccount != null)
            {
                lblAccountInfo.Text = bankAccount.ShowAccountInfo();
            }
            else
            {
                lblAccountInfo.Text = "Рахунок не створено.";
            }
        }
        private void UpdateTransactionHistory()
        {
            if (bankAccount != null)
            {
                listBoxTransactions.Items.Clear();
                foreach (var transaction in bankAccount.TransactionHistory)
                {
                    listBoxTransactions.Items.Add(transaction);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        
    }
}