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
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();
        }

        public void LoadForm(object form)
        {

            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.Show();
            frm.BringToFront();
        }


        private void picSearchClient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbxFindCleint.Text,out int ID ))
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (clsClient.DeleteClienID(ID))
            {
                MessageBox.Show($"Client Deleted Successfully with ID = {ID} " , "Done" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deletion error: Operation failed. Enter a valid ID to complete the deletion process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TbxFindCleint.Text = "";

            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageClients());
        }
    }
}
