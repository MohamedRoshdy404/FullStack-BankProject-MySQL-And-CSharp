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
    public partial class GetAllTransactionLog : Form
    {
        public GetAllTransactionLog()
        {
            InitializeComponent();
            _RefreashGetAllTransactionLog();
        }



        private void _RefreashGetAllTransactionLog()
        {
            dgvGetAllTransactionLog.DataSource = clsTransferLog.GetAllTransactionLog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageTransactions());
        }
    }
}
