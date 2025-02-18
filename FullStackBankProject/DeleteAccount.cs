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
                MessageBox.Show($"Are you sure you want to delete the account {TboxAccountNumber} ?" , "Sure ?" , MessageBoxButtons.OKCancel , MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"The account does not exist. Please enter an existing account number. {TboxAccountNumber} ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
