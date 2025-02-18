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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void BtnFindAccount_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new FindAccount());
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new AddAcoount());
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new DeleteAccount());
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new UpdateAccountNumber());
        }

        private void BtnAccountsList_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new GetAllAccountList());
        }
    }
}
