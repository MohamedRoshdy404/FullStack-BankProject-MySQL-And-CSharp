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
    public partial class AddAcoount : Form
    {
        public AddAcoount()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }


        public void ClearAllTboxAccNumber()
        {
            TboxAccountNumber.Text = "";
            TboxClientID.Text = "";
            TboxAccountBalance.Text = "";
            TboxPasswordAccountNumber.Text = "";

        }

        private void BtnAddNewAccount_Click(object sender, EventArgs e)
        {

            string stringNewAccNumber = TboxAccountNumber.Text;
            clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(TboxAccountNumber.Text);

           

            if (Account != null)
            {

                MessageBox.Show($"The account number {stringNewAccNumber} already exists. Please enter a different number", "Error The account number already exists" , MessageBoxButtons.OK , MessageBoxIcon.Error);

            }
            else
            {
                Account = new clsAccountBusinessLayer();
                Account.AccountNumber = TboxAccountNumber.Text;
                Account.ClientID = Convert.ToInt32(TboxClientID.Text);
                Account.AccountCreationDate = DateTime.Now;
                Account.AccountBalance = Convert.ToDecimal(TboxAccountBalance.Text);
                Account.Password = TboxPasswordAccountNumber.Text;
                

                if (Account.Save())
                {
                    MessageBox.Show("The account has been successfully added", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllTboxAccNumber();
                }
                else
                {
                    MessageBox.Show("The process of creating a new account has failed. Please try again correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAllTboxAccNumber();
                }


            }



        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllTboxAccNumber();
        }
    }
}
