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
    public partial class GetAllAccountList : Form
    {
        public GetAllAccountList()
        {
            InitializeComponent();

            _RefreshGetAllClients();
        }

        private void _RefreshGetAllClients()
        {
            dgvGetAllClients.DataSource = clsAccountBusinessLayer.GetAllAcoounts();

            labNumberTotelAccountBalance.Text = $" [ {SumAllAccountBalance().ToString()} ] ";


        }

        public decimal SumAllAccountBalance()
        {
            decimal TotelsumAccountBalance = 0;
            DataTable dtAcoounts = new DataTable();
            dtAcoounts = clsAccountBusinessLayer.GetAllAcoounts();

            foreach (DataRow rwo in dtAcoounts.Rows)
            {
                TotelsumAccountBalance += Convert.ToDecimal(rwo["AccountBalance"]);
            }

            return TotelsumAccountBalance;

        }

        


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }
    }
}
