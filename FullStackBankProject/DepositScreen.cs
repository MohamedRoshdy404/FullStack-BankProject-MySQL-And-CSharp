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
    public partial class DepositScreen : Form
    {
        public DepositScreen()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageTransactions());   
        }


        private void BtnSerach_Click(object sender, EventArgs e)
        {

            clsTransactionsBusinessLayer FullInfoClientAndAccountClient = clsTransactionsBusinessLayer.GetAllInfoClient_Account(TboxAccountNumber.Text);

            TboxAccountBalance.Text = FullInfoClientAndAccountClient.AccountBalance.ToString();
            TboxClientID.Text = FullInfoClientAndAccountClient.ClientID.ToString();
            TboxFirstName.Text = FullInfoClientAndAccountClient.FirstName.ToString();
            TboxLastName.Text = FullInfoClientAndAccountClient.LastName.ToString();
            TboxEmail.Text = FullInfoClientAndAccountClient.Email.ToString();
            TboxPhone.Text = FullInfoClientAndAccountClient.Phone.ToString();
            TboxCity.Text = FullInfoClientAndAccountClient.City.ToString();
            TboxCountry.Text = FullInfoClientAndAccountClient.Country.ToString();




        }
    }
}
