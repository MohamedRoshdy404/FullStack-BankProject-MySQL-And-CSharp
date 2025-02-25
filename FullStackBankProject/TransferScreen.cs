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
        

        private void AddRowTransfer()
        {
            clsTransferLog TransferLog = new clsTransferLog();
            TransferLog.TransactionDate = DateTime.Now;
            TransferLog.Amount = Convert.ToDecimal(TboxEnterdepositamount.Text);
            TransferLog.TransactionType = "T";
            TransferLog.TransferFrom = SourceClient.AccountNumber;
            TransferLog.TransferTo = DestinationClient.AccountNumber;
            TransferLog.UserID = clsGlobal.UserID;
            TransferLog.Save();
        }

        private void ClearAllTbox()
        {
            TboxAccountBalancefrom.Text  = "";
            TboxClientIDfrom.Text        = "";
            TboxFirstNamefrom.Text       = "";
            TboxLastNamefrom.Text        = "";
            TboxEmailfrom.Text           = "";
            TboxPhonefrom.Text           = "";
            TboxCityfrom.Text            = "";
            TboxCountryfrom.Text         = "";

            TboxAccountBalanceto.Text    = "";
            TboxClientIDto.Text          = "";
            TboxFirstNameto.Text         = "";
            TboxLastNameto.Text          = "";
            TboxEmailto.Text             = "";
            TboxPhoneto.Text             = "";
            TboxCityto.Text              = "";
            TboxCountryto.Text           = "";

            TboxEnterdepositamount.Visible = false;
            BtnClear.Visible = false;
            BtnTransfer.Visible = false;
        }

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
            TboxEnterdepositamount.Text = "";




            TboxEnterdepositamount.Visible = true;
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
            int Amount = Convert.ToInt32(TboxEnterdepositamount.Text);


            
            if (SourceClient.AccountBalance >= Amount)
            {
                SourceClient.AccountBalance -= Amount;
                DestinationClient.AccountBalance += Amount;

                if (SourceClient.UpdateAccountBalance() && DestinationClient.UpdateAccountBalance())
                {
                    MessageBox.Show("The transfer process has succeeded", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddRowTransfer();
                    ClearAllTbox();
                }
                else
                {
                    MessageBox.Show("The transfer process has failed.", "Error The transfer process has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("The process has failed. Make sure that the transfer amount is less than or equal to the amount available in the current account", "Error The transfer process has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAllTbox();
            }







        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllTbox();
        }
    }
}
