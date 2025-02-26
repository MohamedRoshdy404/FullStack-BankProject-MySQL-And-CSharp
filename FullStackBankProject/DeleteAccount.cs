using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullStackBankProject
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        public void ClearTboxAccountNumber()
        {
            TboxAccountNumber.Text = "";
            TboxPasswordAccountNumber.Text = "";
            TboxAccountBalance.Text = "";
            TboxAccountCreationDate.Text = "";
            TboxClientID.Text = "";
        }
        private void BtnSerach_Click(object sender, EventArgs e)
        {

            string AccountNumber = TboxAccountNumber.Text;

            clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(AccountNumber);


            if (Account != null)
            {
                TboxPasswordAccountNumber.Text = Account.Password;
                TboxAccountBalance.Text = Account.AccountBalance.ToString();
                TboxAccountCreationDate.Text = Account.AccountCreationDate.ToString();
                TboxClientID.Text = Account.ClientID.ToString();
            }
            else
            {
                MessageBox.Show("Account data retrieval failed. Please enter a valid account number", "Error The account data retrieval process failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (clsAccountBusinessLayer.isExist(TboxAccountNumber.Text))
            {
                if (MessageBox.Show($"Are you sure you want to delete the account {TboxAccountNumber.Text} ?", "Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (clsAccountBusinessLayer.DeleteAccount(TboxAccountNumber.Text))
                    {
                        MessageBox.Show("The account has been successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTboxAccountNumber();
                    }
                    else
                    {
                        MessageBox.Show("The account deletion process has failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The account deletion process has been canceled.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show($"The account does not exist. Please enter an existing account number. {TboxAccountNumber.Text} ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearTboxAccountNumber();
        }
    }
}
