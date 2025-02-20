using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace FullStackBankProject
{
    public partial class Form1 : Form
    {

        public static Panel myPanel; 

        public Form1()
        {
            InitializeComponent();
            myPanel = mainPanel;
            Form1.loadForm(new ManageClients());
        }

        public static void loadForm(Form form)
        {
            if (form == null)
                return;

            myPanel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            myPanel.Controls.Add(form);
            myPanel.Tag = form;
            form.Show();
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnlistClients_Click(object sender, EventArgs e)
        {
            loadForm(new ManageClients());
        }

        private void labINameUser_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageAccounts());
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            Form1.loadForm(new ManageUsers());
        }
    }
}
