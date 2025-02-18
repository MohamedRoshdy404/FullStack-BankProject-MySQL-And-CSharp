using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullStackBankProject
{
    public partial class FindAccount : Form
    {
        public FindAccount()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
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
                MessageBox.Show("Account data retrieval failed. Please enter a valid account number", "Error The account data retrieval process failed" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearTboxAccountNumber();
        }
    }
}
