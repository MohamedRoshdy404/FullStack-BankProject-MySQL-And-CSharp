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
    public partial class UpdateAccountNumber : Form
    {
        public UpdateAccountNumber()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }
        //clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(TboxAccountNumber.Text);

        public void ClearAllTboxAccNumber()
        {
            TboxAccountNumber.Text = "";
            TboxClientID.Text = "";
            TboxAccountBalance.Text = "";
            TboxPasswordAccountNumber.Text = "";

        }

        private void BtnUpdateAccountNumber_Click(object sender, EventArgs e)
        {

            //clsAccountBusinessLayer AccountNumber = clsAccountBusinessLayer.isExist(TboxAccountNumber.Text);

            clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(TboxSearchAccountNumber.Text);

            TboxSearchAccountNumber.Visible = false;

            Account.AccountNumber = TboxAccountNumber.Text;
            Account.Password = TboxPasswordAccountNumber.Text;
            Account.AccountBalance = Convert.ToDecimal(TboxAccountBalance.Text);
            Account.ClientID = Convert.ToInt32(TboxClientID.Text);

            //if ((clsAccountBusinessLayer.isExist(TboxAccountNumber.Text)) && (clsClient.isExist(Convert.ToInt32(TboxClientID.Text))))
            //{

            //    if (Account.Save())
            //    {
            //        MessageBox.Show("Account updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Account update failed.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }



            if (clsAccountBusinessLayer.isExist(TboxAccountNumber.Text) && int.TryParse(TboxClientID.Text , out int CoientID))
            {



                if (Account.Save())
                {
                    MessageBox.Show("Account updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account update failed.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("The addition process has failed. Make sure that the account number already exists and that the client number associated with this account also exists.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            





        }

        public void BtnSerach_Click(object sender, EventArgs e)
        {
            clsAccountBusinessLayer Account = clsAccountBusinessLayer.FindAccountByAccountNumber(TboxAccountNumber.Text);


            if (Account != null)
            {
                TboxPasswordAccountNumber.Text = Account.Password;
                TboxAccountBalance.Text = Account.AccountBalance.ToString();
                TboxClientID.Text = Account.ClientID.ToString();
                BtnSerach.Visible = false;
            }
            else
            {
                MessageBox.Show("The account does not exist. Please enter an existing account number.", "Error The account data retrieval process failed" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }




        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllTboxAccNumber();
            BtnSerach.Visible = true;
        }
    }
}
