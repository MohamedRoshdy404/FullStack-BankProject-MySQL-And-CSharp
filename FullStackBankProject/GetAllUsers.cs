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
    public partial class GetAllUsers : Form
    {
        public GetAllUsers()
        {
            InitializeComponent();
            _RefreshGetAllUsers();
        }

        private void _RefreshGetAllUsers()
        {
            dgvGetAllUsers.DataSource = clsUserBusinessLayer.GetAllUser();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());   
        }
    }
}
