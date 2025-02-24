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
    public partial class TransferScreen : Form
    {
        public TransferScreen()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageTransactions());
        }

         clsTransactionsBusinessLayer SourceClient;
        clsTransactionsBusinessLayer DestinationClient;

        void GetAllInfoAccfromAndTO()
        {
            TboxAccountBalancefrom.Text = SourceClient.AccountBalance.ToString();
            TboxClientIDfrom.Text = SourceClient.ClientID.ToString();
            TboxFirstNamefrom.Text = SourceClient.FirstName;
            TboxLastNamefrom.Text = SourceClient.LastName.ToString();
            TboxEmailfrom.Text = SourceClient.Email.ToString();
            TboxPhonefrom.Text = SourceClient.Phone.ToString();
            TboxCityfrom.Text = SourceClient.City.ToString();
            TboxCountryfrom.Text = SourceClient.Country.ToString();


            TboxAccountBalanceto.Text = DestinationClient.AccountBalance.ToString();
            TboxClientIDto.Text = DestinationClient.ClientID.ToString();
            TboxFirstNameto.Text = DestinationClient.FirstName;
            TboxLastNameto.Text = DestinationClient.LastName.ToString();
            TboxEmailto.Text = DestinationClient.Email.ToString();
            TboxPhoneto.Text = DestinationClient.Phone.ToString();
            TboxCityto.Text = DestinationClient.City.ToString();
            TboxCountryto.Text = DestinationClient.Country.ToString();




            TboxEnterthedepositamount.Visible = true;
            BtnClear.Visible = true;
            BtnTransfer.Visible = true;
        }


        private void BtnSerach_Click(object sender, EventArgs e)
        {
             SourceClient = clsTransactionsBusinessLayer.GetAllInfoClient_Account(TboxAccountNumberfrom.Text);
             DestinationClient = clsTransactionsBusinessLayer.GetAllInfoClient_Account(TboxAccountNumberto.Text);

            if (SourceClient != null && DestinationClient != null)
            {
                GetAllInfoAccfromAndTO();
            }
            else
            {
                MessageBox.Show("Account data retrieval failed. Please enter a valid account number", "Error The account data retrieval process failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(TboxEnterthedepositamount.Text);


            
            if (SourceClient.AccountBalance >= Amount)
            {
                SourceClient.AccountBalance -= Amount;
                DestinationClient.AccountBalance += Amount;

                if (SourceClient.UpdateAccountBalance() && DestinationClient.UpdateAccountBalance())
                {
                    MessageBox.Show("The transfer process has succeeded", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The transfer process has failed.", "Error The transfer process has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
    }
}
