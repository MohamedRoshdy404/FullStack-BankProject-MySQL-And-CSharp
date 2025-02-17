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
    public partial class GetAllClients : Form
    {
        public GetAllClients()
        {
            InitializeComponent();
            _RefreshGetAllClients();
        }


        private void _RefreshGetAllClients()
        {
            dgvGetAllClients.DataSource = clsClient.GetAllClients();



        }

        private void dgvGetAllClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageClients());
        }
    }
}
