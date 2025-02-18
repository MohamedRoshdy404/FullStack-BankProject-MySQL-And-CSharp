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

        private void BtnSerach_Click(object sender, EventArgs e)
        {
            if (clsAccountBusinessLayer.isExist(TboxAccountNumber.Text))
            {
                if (MessageBox.Show($"Are you sure you want to delete the account {TboxAccountNumber.Text} ?", "Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (clsAccountBusinessLayer.DeleteAccount(TboxAccountNumber.Text))
                    {
                        MessageBox.Show("The account has been successfully deleted." , "Done" , MessageBoxButtons.OK , MessageBoxIcon.Information);
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }
    }
}
