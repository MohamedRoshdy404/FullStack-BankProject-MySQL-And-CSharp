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
    public partial class ManageTransactions : Form
    {
        public ManageTransactions()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageClients());
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new DepositScreen());
        }

        private void BtnTotalBalances_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new GetAllAccountList());
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new WithdrawScreen());
        }
    }
}
